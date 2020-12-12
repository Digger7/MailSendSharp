using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string listToText = "";

        private string fromString = "";
        private string mailserverString = "";
        private string subjectString = "";
        private string messageString = "";
        private string attachString = "";
        private decimal delay = 0;
        private int retryCount = 0;

        public Form1()
        {
            InitializeComponent();
            //otherwise will throw an exception when calling ReportProgress method
            backgroundWorker1.WorkerReportsProgress = true;
            //mandatory. Otherwise we would get an InvalidOperationException when trying to cancel the operation
            backgroundWorker1.WorkerSupportsCancellation = true;

            toolTip1.SetToolTip(buttonClearAttach, "Clear attachment");
            toolTip1.SetToolTip(buttonAttach, "Select attachment");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            sendButton.Enabled = false;

            listToText = toTextBox.Text.Trim();
            if (listToText.Substring(listToText.Length - 1, 1) == ";") listToText = listToText.Substring(0, listToText.Length - 1);

            progressBar1.Minimum = 1;
            progressBar1.Value = 1;

            retryCount = (int)numericUpDownRetryCount.Value;
            delay = numericUpDownDelay.Value;
            fromString = fromTextBox.Text;
            mailserverString = mailserverTextBox.Text;
            subjectString = subjectTextBox.Text;
            messageString = messageTextBox.Text;
            attachString = textBoxAttach.Text;

            backgroundWorker1.RunWorkerAsync();
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы | *.*";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                if (String.IsNullOrEmpty(textBoxAttach.Text))
                {
                    textBoxAttach.Text = openFileDialog.FileName;
                    labelAttachCount.Text = "1";
                }
                else
                {
                    textBoxAttach.Text += ";" + openFileDialog.FileName;
                    labelAttachCount.Text = (Convert.ToInt32(labelAttachCount.Text) + 1).ToString();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime start = DateTime.Now;
            e.Result = "";

            bool error = false;
            string textError = string.Empty;
            var listTo = listToText.Split(';');
            int i = 0;
            foreach (var item in listTo)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    i++;
                    int retryval = retryCount; // Кол-во попыток отправки, в случае ошибки
                  retryLabel:
                    try
                    {
                        //#####################################################################
                        System.Threading.Thread.Sleep((int) delay); //do some intense task here.
                        backgroundWorker1.ReportProgress(i, listTo.Length); //notify progress to main thread.
                        if (backgroundWorker1.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                        //#####################################################################

                        string email = string.Empty;
                        string messageIndividual = string.Empty;
                        var tmp = item.Split(',');
                        if (tmp.Length > 0)
                            email = tmp[0].Trim();
                        if (tmp.Length > 1)
                            messageIndividual = tmp[1].Trim();

                        if (string.IsNullOrEmpty(email)) continue;


                        //отправка почты >
                        var mail = new MailMessage(fromString, email);
                        var client = new SmtpClient
                        {
                            Port = 25,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Host = mailserverString
                        };
                        mail.Subject = subjectString;

                        if (checkBoxMainMessageFirst.Checked)
                        {
                            mail.Body = messageString + " " + messageIndividual;
                        }
                        else
                        {
                            mail.Body = messageIndividual + " " + messageString;
                        }

                        //Вложение
                        //if (!string.IsNullOrEmpty(attachString))
                        //    mail.Attachments.Add(new Attachment(attachString));
                        if (!string.IsNullOrEmpty(attachString.Trim()))
                        {
                            var sAttach = attachString.Trim().Split(';');
                            foreach (string itemAttach in sAttach)
                            {
                                if (!string.IsNullOrEmpty(itemAttach))
                                    mail.Attachments.Add(new Attachment(itemAttach));
                            }
                        }
                        
                        mail.IsBodyHtml = true;

                        client.Send(mail);
                        //отправка почты <
                    }
                    catch (Exception ex)
                    {
                        if (retryval > 0)
                        {
                            retryval--;
                            goto retryLabel;
                        };
                        error = true;
                        textError += i.ToString() + " | " + item.Trim() + " | " + ex.Message + Environment.NewLine;
                        //?>
                        /*
                           var exception = ex as SmtpFailedRecipientException;
                           if (exception != null)
                               if (exception.StatusCode == SmtpStatusCode.MailboxUnavailable) break;
                        */
                        //?<
                    }
            }
        }
            MessageBox.Show("Операция завершена. " + (error ? "\r\n\r\nВ процессе возникли ошибки. Информация в Error.log" : ""));
            if (error)
            {
                System.IO.File.WriteAllText(@"Error.log", textError);
            }
            TimeSpan duration = DateTime.Now - start;
            e.Result = "Duration: " + duration.TotalMilliseconds.ToString() + " ms.";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.UserState;
            progressBar1.Value = e.ProgressPercentage; //update progress bar
            labelInfo.Text = e.ProgressPercentage.ToString() + " / " + e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sendButton.Enabled = true;
            if (e.Cancelled)
            {
                MessageBox.Show("The task has been cancelled");
                labelInfo.Text += " " + "cancelled";
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());
                labelInfo.Text += " " + "error";
            }
            else
            {
                progressBar1.Value = progressBar1.Maximum;
                labelInfo.Text += " " + e.Result.ToString();
            }
        }

        private void buttonClearAttach_Click(object sender, EventArgs e)
        {
            textBoxAttach.Clear();
            labelAttachCount.Text = "0";
        }

        private void textBoxAttach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
