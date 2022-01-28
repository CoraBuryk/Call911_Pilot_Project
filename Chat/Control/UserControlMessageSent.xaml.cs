using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Project.Log;
using Project.Script;
using Chat.Messages;

namespace Chat.UserControl
{
    /// <summary>
    /// Interaction logic for UserControlMessageSent.xaml
    /// </summary>
    public partial class UserControlMessageSent : System.Windows.Controls.UserControl
    {
        Logger<UserControlMessageSent> logger = new();
        MessageEventArgs args = new();
        FromUserOne userOne = new();
        FromUserTwo userTwo = new();
        string text = null;
        public UserControlMessageSent()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }
            Time.Text = $"{DateTime.Now.ToShortTimeString()}";

            logger.Debug("UserControlMessageSent started");
        }
        public async Task SendLeftAsync0()
        {
            await Task.Delay(3000);
            args.Message = userOne.SendBy0();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync1()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy1();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync2()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy2();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync3()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy3();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync4()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy4();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync5()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy5();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync6()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy6();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync7()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy7();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync8()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy8();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync9()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy9();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync11()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy11();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync12()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy12();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync13()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy13();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync14()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy14();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync16()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy16();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync20()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy20();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendLeftAsync21()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userOne.SendBy21();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        //public async Task SendLeftAsync17()
        //{
        //    User.Text = String.Empty;
        //    await Task.Delay(1000);

        //    //args.Message = userOne.SendBy21();
        //    User.Text += args.Message;
        //    User.Dispatcher.Invoke(() => text = User.Text);
        //}

        public async Task SendRightAsync0()
        {
            await Task.Delay(3000);
            args.Message = userTwo.SendBy0();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync1()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy1();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync2()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy2();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync3()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy3();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync4()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy4();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync5()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy5();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync6()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy6();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync7()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy7();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync8()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy8();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync9()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy9();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync11()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy11();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync12()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy12();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync13()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy13();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync14()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy14();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync16()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy16();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync20()
        {
            //User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy20();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        public async Task SendRightAsync21()
        {
           // User.Text = String.Empty;
            await Task.Delay(1000);

            args.Message = userTwo.SendBy21();
            User.Text += args.Message;
            User.Dispatcher.Invoke(() => text = User.Text);
        }
        //public async Task SendRightAsync17()
        //{
        //    User.Text = String.Empty;
        //    await Task.Delay(1000);

        //    args.Message = userTwo.SendBy21();
        //    User.Text += args.Message;
        //    User.Dispatcher.Invoke(() => text = User.Text);
        //}
    }
}

