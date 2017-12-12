using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MailBlaster
{
    class SendMail
    {
        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }
        public SendMail(string HTML,string subject, string emailer,string emailee, string displayName)
        {

            string server = ServerSettings.Default.server;
            string username = ServerSettings.Default.user;
            string password = ServerSettings.Default.password;

            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient(server);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(username, password);
            client.Host = server;
            client.Port = 587;
            client.EnableSsl = true;
            // Specify the e-mail sender.
            // Create a mailing address that includes a UTF8 character
            // in the display name.
            MailAddress from = new MailAddress(emailer, displayName);
            // Set destinations for the e-mail message.
            MailAddress to = new MailAddress(emailee);
            // Specify the message content.
            MailMessage message = new MailMessage(from, to);
            MailAddress bcc = new MailAddress("ryan@motionlit.com");
            message.Bcc.Add(bcc);            //message.Body = HTML;
            // Include some non-ASCII characters in body and subject.
            string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
            message.IsBodyHtml = true;
            message.Body = HTML;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = subject;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback 
            // method to identify this send operation.
            // For this example, the userToken is a string constant.
            string userState = "test message1";
            client.SendAsync(message, userState);
            Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
            string answer = Console.ReadLine();
            // If the user canceled the send, and mail hasn't been sent yet,
            // then cancel the pending operation.
            /*
            if (answer.StartsWith("c") && mailSent == false)
            {
                client.SendAsyncCancel();
            }*/
            // Clean up.
            //message.Dispose();
            //Console.WriteLine("Goodbye.");
        }
    }
}
