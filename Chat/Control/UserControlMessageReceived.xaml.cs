using Chat.Messages;
using Project.Log;
using Project.Script;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat
{
    /// <summary>
    /// Interaction logic for UserControlMessageReceived.xaml
    /// </summary>
    public partial class UserControlMessageReceived : System.Windows.Controls.UserControl
    {
        Logger<UserControlMessageReceived> logger = new();
        MessageEventArgs args = new();
        ForUserOne forUser = new();
        string text = null;
        Image image = null;
        
        public UserControlMessageReceived()
        {
            try
            {
                InitializeComponent();
            }
            catch (StackOverflowException ex)
            {
                logger.Error(ex);
                throw;
            }

            Time.Text = $"{DateTime.Now.ToShortTimeString()}";
            logger.Debug("UserControlMessageReceived started");
        }

        public async Task SendAsync0()
        {
            await Task.Delay(5000);
            args.Message = forUser.SentTo0();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync2_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo2_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }

        public async Task SendAsync2_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo2_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync3_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo3_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync3_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo3_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync4_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo4_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync4_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo4_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync5()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo5();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync6()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo6();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);

        }
        public async Task SendAsync7()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo7();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync8_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo8_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync8_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo8_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync9_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo9_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync9_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo9_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync10_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo10_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }

        public async Task SendAsync10_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo10_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }

        public async Task SendAsync12_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo12_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);

        }
        public async Task SendAsync12_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo12_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync13()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo13();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }

        public async Task SendAsync14()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo14();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);

        }
        public async Task SendAsync15_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo15_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync15_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo15_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync16_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo16_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync16_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo16_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync17_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo17_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync17_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo17_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync18_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo18_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync18_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo18_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync19_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo19_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync19_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo19_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync21_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo21_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync21_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo21_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync22_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo22_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync22_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo22_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }

        public async Task SendAsync23_1()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo23_1();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
        public async Task SendAsync23_2()
        {
            await Task.Delay(2000);
            Code.Text = String.Empty;
            await Task.Delay(3000);
            args.Message = forUser.SentTo23_2();
            Code.Text += args.Message;
            Code.Dispatcher.Invoke(() => text = Code.Text);
        }
    }
}
