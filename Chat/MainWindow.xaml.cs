using Chat.Content;
using Chat.Core;
using Chat.Messages;
using Chat.UserControl;
using Project.Log;
using Project.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
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
using static Project.Script.IVariations;

namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logger<MainWindow> logger = new();

        private TaskCompletionSource<bool> clickWaitTask;
        private Button ClickedButton;
        private SoundPlayer player = new SoundPlayer();

        public MainWindow()
        {
            try
            {
                InitializeComponent();

                logger.Info("Chat Main Window started");
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }
            finally
            {
                logger.Info("Application closed");
            }
            Border.Visibility = Visibility.Visible;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            DragMove();
            logger.Info("Screen Chat moved");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            logger.Info("Application Chat closed");
        }

        public async void Right_ButtonClick(object sender, RoutedEventArgs e)
        {
            logger.Info("Right Button Click");

            clickWaitTask.TrySetResult(true);
            Click_Sound();
        }

        public async void Left_ButtonClick(object sender, RoutedEventArgs e)
        {
            logger.Info("Left Button Click");

            clickWaitTask.TrySetResult(false);
            Click_Sound();
        }

        public void Click_Sound()
        {
           try
           {
                player.SoundLocation = @"D:\Project\Login\Chat\Sounds\click.wav";
                player.Load();
                player.Play();
                player.Dispose();
                logger.Debug("Sound of click after press the buttoms");
           }

            catch (FileNotFoundException e)  
           {
                logger.Error(e);
                throw;
           }
        }

        public void Message_Sound()
        {
            try
            {
                player.SoundLocation = @"D:\Project\Login\Chat\Sounds\message.wav";
                player.Load();
                player.Play();
                player.Dispose();
                logger.Debug("Sound of received message");
            }
            catch (FileNotFoundException e)
            {
                logger.Error(e);
                throw;
            }
        }

        public async Task Start()
        {
            Left.Text = "Start";
            Right.Text = "Start";

            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent0.SendRightAsync0();
                Sent0.Visibility = Visibility.Visible;

                Received0.SendAsync0();
                await Task.Delay(3000);
                Received0.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.what);
                Right.Text = Option.GetVariation(Variation.repeat);
            }
            else
            {
                Sent0.SendLeftAsync0();
                Sent0.Visibility = Visibility.Visible;

                Received0.SendAsync0();
                await Task.Delay(3000);
                Received0.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.what);
                Right.Text = Option.GetVariation(Variation.repeat);
            }
            logger.Debug("First choise: start");
        }

        public async Task First()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent1.SendRightAsync1();
                Sent1.Visibility = Visibility.Visible;

                Received1.SendAsync1();
                await Task.Delay(3000);
                Received1.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.name);
                Right.Text = Option.GetVariation(Variation.adress);
            }
            else
            {
                Sent1.SendLeftAsync1();
                Sent1.Visibility = Visibility.Visible;

                Received1.SendAsync1();
                await Task.Delay(3000);
                Received1.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.name);
                Right.Text = Option.GetVariation(Variation.adress);
            }
            logger.Debug("Second choise: ask name or adress");
        }

        public async Task Second()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent2.SendRightAsync2();
                Sent2.Visibility = Visibility.Visible;

                Received2.SendAsync2_2();
                await Task.Delay(3000);
                Received2.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.see);
                Right.Text = Option.GetVariation(Variation.alone);
            }
            else
            {
                Sent2.SendLeftAsync2();
                Sent2.Visibility = Visibility.Visible;

                Received2.SendAsync2_1();
                await Task.Delay(3000);
                Received2.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.see);
                Right.Text = Option.GetVariation(Variation.alone);
            }
            logger.Debug("Third choise: see him or alone in house");
        }

        public async Task Third()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent3.SendRightAsync3();
                Sent3.Visibility = Visibility.Visible;

                Received3.SendAsync3_2();
                await Task.Delay(3000);
                Received3.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.stay);
                Right.Text = Option.GetVariation(Variation.confirm);
            }
            else
            {
                Sent3.SendLeftAsync3();
                Sent3.Visibility = Visibility.Visible;

                Received3.SendAsync3_1();
                await Task.Delay(3000);
                Received3.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.stay);
                Right.Text = Option.GetVariation(Variation.confirm);
            }
            logger.Debug("Fourth choise: ask for stay on phone or confirm that doors locked");
        }

        public async Task Fourth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent4.SendRightAsync4();
                Sent4.Visibility = Visibility.Visible;

                Received4.SendAsync4_1();
                await Task.Delay(3000);
                Received4.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.strange);
                Right.Text = Option.GetVariation(Variation.there);
            }
            else
            {
                Sent4.SendLeftAsync4();
                Sent4.Visibility = Visibility.Visible;

                Received4.SendAsync4_2();
                await Task.Delay(3000);
                Received4.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.strange);
                Right.Text = Option.GetVariation(Variation.there);
            }
            logger.Debug("Fifth choise: ask about something strange or caller on line");
        }

        public async Task Fifth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent6.SendRightAsync5();
                Sent6.Visibility = Visibility.Visible;

                Sent7.SendRightAsync6();
                await Task.Delay(3000);
                Sent7.Visibility = Visibility.Visible;

                Received7.SendAsync5();
                await Task.Delay(3000);
                Received7.Visibility = Visibility.Visible;
                Message_Sound();

                Received8.SendAsync6();
                await Task.Delay(3000);
                Received8.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.say);
                Right.Text = Option.GetVariation(Variation.handstand);
            }
            else
            {
                Sent6.SendLeftAsync5();
                Sent6.Visibility = Visibility.Visible;

                Sent7.SendLeftAsync6();
                await Task.Delay(3000);
                Sent7.Visibility = Visibility.Visible;

                Received7.SendAsync5();
                await Task.Delay(3000);
                Received7.Visibility = Visibility.Visible;
                Message_Sound();

                Received8.SendAsync6();
                await Task.Delay(3000);
                Received8.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.say);
                Right.Text = Option.GetVariation(Variation.handstand);
            }
            logger.Debug("Sixth choise: ask again or specify");
        }

        public async Task Sixth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent9.SendRightAsync7();
                Sent9.Visibility = Visibility.Visible;

                Received9.SendAsync7();
                await Task.Delay(3000);
                Received9.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.describe);
                Right.Text = Option.GetVariation(Variation.calm);
            }
            else
            {
                Sent9.SendLeftAsync7();
                Sent9.Visibility = Visibility.Visible;

                Received9.SendAsync7();
                await Task.Delay(3000);
                Received9.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.describe);
                Right.Text = Option.GetVariation(Variation.calm);
            }
            logger.Debug("Seventh choise: ask for describe person or keep calm");
        }

        public async Task Seventh()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent10.SendRightAsync8();
                Sent10.Visibility = Visibility.Visible;

                Received10.SendAsync8_1();
                await Task.Delay(3000);
                Received10.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.location);
                Right.Text = Option.GetVariation(Variation.secured);
            }
            else
            {
                Sent10.SendLeftAsync8();
                Sent10.Visibility = Visibility.Visible;

                Received10.SendAsync8_2();
                await Task.Delay(3000);
                Received10.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.location);
                Right.Text = Option.GetVariation(Variation.secured);
            }
            logger.Debug("Eighth choise: ask about location or say to be secured");
        }

        public async Task Eighth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent11.SendRightAsync9();
                Sent11.Visibility = Visibility.Visible;

                Received11.SendAsync9_1();
                await Task.Delay(3000);
                Received11.Visibility = Visibility.Visible;
                Message_Sound();

                Received12.SendAsync10_1();
                await Task.Delay(3000);
                Received12.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.stay);
                Right.Text = Option.GetVariation(Variation.help);
            }
            else
            {
                Sent11.SendLeftAsync9();
                Sent11.Visibility = Visibility.Visible;

                Received11.SendAsync9_2();
                await Task.Delay(3000);
                Received11.Visibility = Visibility.Visible;
                Message_Sound();

                Received12.SendAsync10_2();
                await Task.Delay(3000);
                Received12.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.stay);
                Right.Text = Option.GetVariation(Variation.help);
            }
            logger.Debug("Ninth choise: ask for stay on line or say that help is near");
        }

        public async Task Ninth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent13.SendRightAsync11();
                Sent13.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.talk);
                Right.Text = Option.GetVariation(Variation.there);
            }
            else
            {
                Sent13.SendLeftAsync11();
                Sent13.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.talk);
                Right.Text = Option.GetVariation(Variation.there);
            }
            logger.Debug("Tenth choise: ask for talking or ask is caller on line");
        }

        public async Task Tenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent14.SendRightAsync12();
                await Task.Delay(3000);
                Sent14.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Image1.Visibility = Visibility.Visible;
                logger.Debug("Image1 on screen");
                Message_Sound();

                await Task.Delay(1000);
                Received15.SendAsync13();
                await Task.Delay(1000);
                Received15.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(1000);
                Received16.SendAsync14();
                await Task.Delay(2000);
                Received16.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.hide);
                Right.Text = Option.GetVariation(Variation.protect);
            }
            else
            {
                Sent14.SendLeftAsync12();
                await Task.Delay(3000);
                Sent14.Visibility = Visibility.Visible;

                Received14.SendAsync12_1();
                await Task.Delay(3000);
                Received14.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(1000);
                Received15.SendAsync13();
                await Task.Delay(1000);
                Received15.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(1000);
                Received16.SendAsync14();
                await Task.Delay(2000);
                Received16.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.hide);
                Right.Text = Option.GetVariation(Variation.protect);
            }
            logger.Debug("Eleventh choise: ask for hide or protect himself");
        }

        public async Task Eleventh()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent17.Visibility = Visibility.Visible;
                Sent17.SendRightAsync13();

                Sent18.Visibility = Visibility.Visible;
                await Task.Delay(3000);
                Sent18.SendRightAsync14();

                Received18.SendAsync15_2();
                await Task.Delay(3000);
                Received18.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.prepared);
                Right.Text = Option.GetVariation(Variation.alone);
            }
            else
            {
                Sent17.Visibility = Visibility.Visible;
                Sent17.SendLeftAsync13();

                Sent18.Visibility = Visibility.Visible;
                await Task.Delay(3000);
                Sent18.SendLeftAsync14();

                Received18.SendAsync15_1();
                await Task.Delay(3000);
                Received18.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.prepared);
                Right.Text = Option.GetVariation(Variation.alone);
            }
            logger.Debug("Twelfth choise: ask for be prepared or ask is he alone");
        }

        public async Task Twelfth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent19.SendRightAsync16();
                Sent19.Visibility = Visibility.Visible;

                Received19.SendAsync16_1();
                await Task.Delay(3000);
                Received19.Visibility = Visibility.Visible;
                Message_Sound();

                Received20.SendAsync17_1();
                await Task.Delay(3000);
                Received20.Visibility = Visibility.Visible;
                Message_Sound();

                Received21.SendAsync18_1();
                await Task.Delay(3000);
                Received21.Visibility = Visibility.Visible;
                Message_Sound();

                Received22.SendAsync19_1();
                await Task.Delay(3000);
                Received22.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.police);
                Right.Text = Option.GetVariation(Variation.say);
            }
            else
            {
                Sent19.SendLeftAsync16();
                Sent19.Visibility = Visibility.Visible;

                Received19.SendAsync16_2();
                await Task.Delay(3000);
                Received19.Visibility = Visibility.Visible;
                Message_Sound();

                Received20.SendAsync17_2();
                await Task.Delay(3000);
                Received20.Visibility = Visibility.Visible;
                Message_Sound();

                Received21.SendAsync18_2();
                await Task.Delay(3000);
                Received21.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Play1.Visibility = Visibility.Visible;
                Message_Sound();

                Received22.SendAsync19_2();
                await Task.Delay(3000);
                Received22.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.police);
                Right.Text = Option.GetVariation(Variation.say);
            }
            logger.Debug("Thirteenth choise: ask for repeat or say police on their way");
        }

        public async Task Thirteenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent23.SendRightAsync20();
                Sent23.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.there);
                Right.Text = Option.GetVariation(Variation.what);
            }
            else
            {
                Sent23.SendLeftAsync20();
                Sent23.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.there);
                Right.Text = Option.GetVariation(Variation.what);
            }
            logger.Debug("Fourteenth choise: ask is caller on line or what going on");
        }

        public async Task Fourteenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Sent24.SendRightAsync21();
                Sent24.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Image3.Visibility = Visibility.Visible;
                logger.Debug("Image3 on screen");
                Message_Sound();

                Received25.SendAsync22_1();
                await Task.Delay(3000);
                Received25.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Play2.Visibility = Visibility.Visible;
                Message_Sound();

                Received26.SendAsync23_1();
                await Task.Delay(3000);
                Received26.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.hear);
                Right.Text = Option.GetVariation(Variation.police); ;
            }
            else
            {
                Sent24.SendLeftAsync21();
                Sent24.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Image2.Visibility = Visibility.Visible;
                logger.Debug("Image2 on screen");
                Message_Sound();

                Received25.SendAsync22_2();
                await Task.Delay(3000);
                Received25.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Play2.Visibility = Visibility.Visible;
                Message_Sound();

                Received26.SendAsync23_2();
                await Task.Delay(3000);
                Received26.Visibility = Visibility.Visible;
                Message_Sound();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.hear);
                Right.Text = Option.GetVariation(Variation.police);
            }
            logger.Debug("Fifthteenth choise: ask is he hear us or say police on their way. Optional. No answer");
        }

        public async Task Fifthteenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Error1.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.repeat);
                Right.Text = Option.GetVariation(Variation.there);
            }
            else
            {
                Error1.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(3000);

                Left.Text = Option.GetVariation(Variation.repeat);
                Right.Text = Option.GetVariation(Variation.there);
            }
            logger.Debug("Sixteenth choise: ask for repeat or ask is caller on line. Optional. No answer");
        }
        public async Task Sixteenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                Error2.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.what);
                Right.Text = Option.GetVariation(Variation.right);
            }
            else
            {
                Error2.Visibility = Visibility.Visible;

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);

                Left.Text = Option.GetVariation(Variation.what);
                Right.Text = Option.GetVariation(Variation.right);
            }
            logger.Debug("Seventeenth choise: ask is he all right or what happening. Optional. No answer");
        }

        public async Task Seventeenth()
        {
            ClickedButton = new Button();

            clickWaitTask = new TaskCompletionSource<bool>();

            if (ClickedButton != Right_btn && await clickWaitTask.Task)
            {
                new End().ShowDialog();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);
            }
            else
            {
                new End().ShowDialog();

                await Task.Delay(3000);
                Right.Text = string.Empty;
                Left.Text = string.Empty;
                await Task.Delay(1000);
            }
            logger.Debug("End screen");
        }

        public async Task Conversation()
        {
            Start();
            await clickWaitTask.Task;
            First();
            await clickWaitTask.Task;
            Second();
            await clickWaitTask.Task;
            Third();
            await clickWaitTask.Task;
            Fourth();
            await clickWaitTask.Task;
            Fifth();
            await clickWaitTask.Task;
            Sixth();
            await clickWaitTask.Task;
            Seventh();
            await clickWaitTask.Task;
            Eighth();
            await clickWaitTask.Task;
            Ninth();
            await clickWaitTask.Task;
            Tenth();
            await clickWaitTask.Task;
            Eleventh();
            await clickWaitTask.Task;
            Twelfth();
            await clickWaitTask.Task;
            Thirteenth();
            await clickWaitTask.Task;
            Fourteenth();
            await clickWaitTask.Task;
            Fifthteenth();
            await clickWaitTask.Task;
            Sixteenth();
            await clickWaitTask.Task;
            Seventeenth();
        }

        private void Unknown_ButtonClick(object sender, RoutedEventArgs e)
        {
            Color.Visibility = Visibility.Visible;
            Call.Visibility = Visibility.Visible;
            VideoCall.Visibility = Visibility.Visible;
            Left_btn.Visibility = Visibility.Visible;
            Right_btn.Visibility = Visibility.Visible;
            Send.Visibility = Visibility.Visible;
            Attachment.Visibility = Visibility.Visible;
            Smiley.Visibility = Visibility.Visible;

            StartMessage.Visibility = Visibility.Collapsed;
            Message1.Visibility = Visibility.Collapsed;
            Message2.Visibility = Visibility.Collapsed;
            Message3.Visibility = Visibility.Collapsed;
            Message4.Visibility = Visibility.Collapsed;
            Message5.Visibility = Visibility.Collapsed;
            Message6.Visibility = Visibility.Collapsed;

            Left.Text = String.Empty;
            Right.Text = String.Empty;
            Conversation();
            Name.Text = "Unknown";
        }

        private void Allison_ButtonClick(object sender, RoutedEventArgs e)
        {
            Color.Visibility = Visibility.Visible;
            Call.Visibility = Visibility.Visible;
            VideoCall.Visibility = Visibility.Visible;
            Left_btn.Visibility = Visibility.Visible;
            Right_btn.Visibility = Visibility.Visible;
            Send.Visibility = Visibility.Visible;
            Attachment.Visibility = Visibility.Visible;
            Smiley.Visibility = Visibility.Visible;     
            
            Left.Text = String.Empty;
            Right.Text = String.Empty;

            StartMessage.Visibility = Visibility.Visible;
            Message1.Visibility = Visibility.Visible;

            Message2.Visibility = Visibility.Collapsed;
            Message3.Visibility = Visibility.Collapsed;
            Message4.Visibility = Visibility.Collapsed;
            Message5.Visibility = Visibility.Collapsed;
            Message6.Visibility = Visibility.Collapsed;

            Sent0.Visibility = Visibility.Collapsed;
            Received0.Visibility = Visibility.Collapsed;
            Received1.Visibility = Visibility.Collapsed;
            Received2.Visibility = Visibility.Collapsed;
            Received3.Visibility = Visibility.Collapsed;
            Received4.Visibility = Visibility.Collapsed;
            Received5.Visibility = Visibility.Collapsed;
            Received6.Visibility = Visibility.Collapsed;
            Received7.Visibility = Visibility.Collapsed;
            Received8.Visibility = Visibility.Collapsed;
            Received9.Visibility = Visibility.Collapsed;
            Received10.Visibility = Visibility.Collapsed;
            Received11.Visibility = Visibility.Collapsed;
            Received12.Visibility = Visibility.Collapsed;
            Received13.Visibility = Visibility.Collapsed;
            Received14.Visibility = Visibility.Collapsed;
            Received15.Visibility = Visibility.Collapsed;
            Received16.Visibility = Visibility.Collapsed;
            Received17.Visibility = Visibility.Collapsed;
            Received18.Visibility = Visibility.Collapsed;
            Received19.Visibility = Visibility.Collapsed;
            Received20.Visibility = Visibility.Collapsed;
            Received21.Visibility = Visibility.Collapsed;
            Received22.Visibility = Visibility.Collapsed;
            Received23.Visibility = Visibility.Collapsed;
            Received24.Visibility = Visibility.Collapsed;
            Received25.Visibility = Visibility.Collapsed;
            Received26.Visibility = Visibility.Collapsed;

            Sent1.Visibility = Visibility.Collapsed;
            Sent2.Visibility = Visibility.Collapsed;
            Sent3.Visibility = Visibility.Collapsed;
            Sent4.Visibility = Visibility.Collapsed;
            Sent5.Visibility = Visibility.Collapsed;
            Sent6.Visibility = Visibility.Collapsed;
            Sent7.Visibility = Visibility.Collapsed;
            Sent8.Visibility = Visibility.Collapsed;
            Sent9.Visibility = Visibility.Collapsed;
            Sent10.Visibility = Visibility.Collapsed;
            Sent11.Visibility = Visibility.Collapsed;
            Sent12.Visibility = Visibility.Collapsed;
            Sent13.Visibility = Visibility.Collapsed;
            Sent14.Visibility = Visibility.Collapsed;
            Sent15.Visibility = Visibility.Collapsed;
            Sent16.Visibility = Visibility.Collapsed;
            Sent17.Visibility = Visibility.Collapsed;
            Sent18.Visibility = Visibility.Collapsed;
            Sent19.Visibility = Visibility.Collapsed;
            Sent20.Visibility = Visibility.Collapsed;
            Sent21.Visibility = Visibility.Collapsed;
            Sent22.Visibility = Visibility.Collapsed;
            Sent23.Visibility = Visibility.Collapsed;
            Sent24.Visibility = Visibility.Collapsed;
            Sent25.Visibility = Visibility.Collapsed;
            Sent26.Visibility = Visibility.Collapsed;

            Image1.Visibility = Visibility.Collapsed;
            Image2.Visibility = Visibility.Collapsed;
            Image3.Visibility = Visibility.Collapsed;
            Play1.Visibility = Visibility.Collapsed;
            Play2.Visibility = Visibility.Collapsed;

            Message1.Code.Text = "Bye";
            StartMessage.User.Text = "Bye!";
            Name.Text = "Allison";
            logger.Debug("User Allison chosen");
        }

        private void Trace_ButtonClick(object sender, RoutedEventArgs e)
        {
            Color.Visibility = Visibility.Visible;
            Call.Visibility = Visibility.Visible;
            VideoCall.Visibility = Visibility.Visible;
            Left_btn.Visibility = Visibility.Visible;
            Right_btn.Visibility = Visibility.Visible;
            Send.Visibility = Visibility.Visible;
            Attachment.Visibility = Visibility.Visible;
            Smiley.Visibility = Visibility.Visible;

            Left.Text = String.Empty;
            Right.Text = String.Empty;

            StartMessage.Visibility = Visibility.Visible;
            Message1.Visibility = Visibility.Visible;
            Message2.Visibility = Visibility.Visible;
            Message3.Visibility = Visibility.Visible;
            Message4.Visibility = Visibility.Visible;
            Message5.Visibility = Visibility.Visible;
            Message6.Visibility = Visibility.Visible;

            Received0.Visibility = Visibility.Collapsed;
            Received1.Visibility = Visibility.Collapsed;
            Received2.Visibility = Visibility.Collapsed;
            Received3.Visibility = Visibility.Collapsed;
            Received4.Visibility = Visibility.Collapsed;
            Received5.Visibility = Visibility.Collapsed;
            Received6.Visibility = Visibility.Collapsed;
            Received7.Visibility = Visibility.Collapsed;
            Received8.Visibility = Visibility.Collapsed;
            Received9.Visibility = Visibility.Collapsed;
            Received10.Visibility = Visibility.Collapsed;
            Received11.Visibility = Visibility.Collapsed;
            Received12.Visibility = Visibility.Collapsed;
            Received13.Visibility = Visibility.Collapsed;
            Received14.Visibility = Visibility.Collapsed;
            Received15.Visibility = Visibility.Collapsed;
            Received16.Visibility = Visibility.Collapsed;
            Received17.Visibility = Visibility.Collapsed;
            Received18.Visibility = Visibility.Collapsed;
            Received19.Visibility = Visibility.Collapsed;
            Received20.Visibility = Visibility.Collapsed;
            Received21.Visibility = Visibility.Collapsed;
            Received22.Visibility = Visibility.Collapsed;
            Received23.Visibility = Visibility.Collapsed;
            Received24.Visibility = Visibility.Collapsed;
            Received25.Visibility = Visibility.Collapsed;
            Received26.Visibility = Visibility.Collapsed;

            Sent0.Visibility = Visibility.Collapsed;
            Sent1.Visibility = Visibility.Collapsed;
            Sent2.Visibility = Visibility.Collapsed;
            Sent3.Visibility = Visibility.Collapsed;
            Sent4.Visibility = Visibility.Collapsed;
            Sent5.Visibility = Visibility.Collapsed;
            Sent6.Visibility = Visibility.Collapsed;
            Sent7.Visibility = Visibility.Collapsed;
            Sent8.Visibility = Visibility.Collapsed;
            Sent9.Visibility = Visibility.Collapsed;
            Sent10.Visibility = Visibility.Collapsed;
            Sent11.Visibility = Visibility.Collapsed;
            Sent12.Visibility = Visibility.Collapsed;
            Sent13.Visibility = Visibility.Collapsed;
            Sent14.Visibility = Visibility.Collapsed;
            Sent15.Visibility = Visibility.Collapsed;
            Sent16.Visibility = Visibility.Collapsed;
            Sent17.Visibility = Visibility.Collapsed;
            Sent18.Visibility = Visibility.Collapsed;
            Sent19.Visibility = Visibility.Collapsed;
            Sent20.Visibility = Visibility.Collapsed;
            Sent21.Visibility = Visibility.Collapsed;
            Sent22.Visibility = Visibility.Collapsed;
            Sent23.Visibility = Visibility.Collapsed;
            Sent24.Visibility = Visibility.Collapsed;
            Sent25.Visibility = Visibility.Collapsed;
            Sent26.Visibility = Visibility.Collapsed;

            Image1.Visibility = Visibility.Collapsed;
            Image2.Visibility = Visibility.Collapsed;
            Image3.Visibility = Visibility.Collapsed;
            Play1.Visibility = Visibility.Collapsed;
            Play2.Visibility = Visibility.Collapsed;

            Message1.Code.Text = "Glad you agree";
            Message2.Code.Text = "Oh...";
            Message3.Code.Text = "By the way";
            Message4.Code.Text = "Bring warm clothes with you";
            Message5.Code.Text = "Friday night we go out of town";
            Message6.Code.Text = "Don't forget about it!";
            StartMessage.User.Text = "Yeah, you are right";
            Name.Text = "Trace";
            logger.Debug("User Trace chosen");
        }

        private void Ken_ButtonClick(object sender, RoutedEventArgs e)
        {
            Color.Visibility = Visibility.Visible;
            Call.Visibility = Visibility.Visible;
            VideoCall.Visibility = Visibility.Visible;
            Left_btn.Visibility = Visibility.Visible;
            Right_btn.Visibility = Visibility.Visible;
            Send.Visibility = Visibility.Visible;
            Attachment.Visibility = Visibility.Visible;
            Smiley.Visibility = Visibility.Visible;

            Left.Text = String.Empty;
            Right.Text = String.Empty;

            StartMessage.Visibility = Visibility.Visible;
            Message1.Visibility = Visibility.Visible;
            Message2.Visibility = Visibility.Visible;
            Message2.Visibility = Visibility.Collapsed;
            Message3.Visibility = Visibility.Collapsed;
            Message4.Visibility = Visibility.Collapsed;
            Message5.Visibility = Visibility.Collapsed;
            Message6.Visibility = Visibility.Collapsed;

            Received0.Visibility = Visibility.Collapsed;
            Received1.Visibility = Visibility.Collapsed;
            Received2.Visibility = Visibility.Collapsed;
            Received3.Visibility = Visibility.Collapsed;
            Received4.Visibility = Visibility.Collapsed;
            Received5.Visibility = Visibility.Collapsed;
            Received6.Visibility = Visibility.Collapsed;
            Received7.Visibility = Visibility.Collapsed;
            Received8.Visibility = Visibility.Collapsed;
            Received9.Visibility = Visibility.Collapsed;
            Received10.Visibility = Visibility.Collapsed;
            Received11.Visibility = Visibility.Collapsed;
            Received12.Visibility = Visibility.Collapsed;
            Received13.Visibility = Visibility.Collapsed;
            Received14.Visibility = Visibility.Collapsed;
            Received15.Visibility = Visibility.Collapsed;
            Received16.Visibility = Visibility.Collapsed;
            Received17.Visibility = Visibility.Collapsed;
            Received18.Visibility = Visibility.Collapsed;
            Received19.Visibility = Visibility.Collapsed;
            Received20.Visibility = Visibility.Collapsed;
            Received21.Visibility = Visibility.Collapsed;
            Received22.Visibility = Visibility.Collapsed;
            Received23.Visibility = Visibility.Collapsed;
            Received24.Visibility = Visibility.Collapsed;
            Received25.Visibility = Visibility.Collapsed;
            Received26.Visibility = Visibility.Collapsed;

            Sent0.Visibility = Visibility.Collapsed;
            Sent1.Visibility = Visibility.Collapsed;
            Sent2.Visibility = Visibility.Collapsed;
            Sent3.Visibility = Visibility.Collapsed;
            Sent4.Visibility = Visibility.Collapsed;
            Sent5.Visibility = Visibility.Collapsed;
            Sent6.Visibility = Visibility.Collapsed;
            Sent7.Visibility = Visibility.Collapsed;
            Sent8.Visibility = Visibility.Collapsed;
            Sent9.Visibility = Visibility.Collapsed;
            Sent10.Visibility = Visibility.Collapsed;
            Sent11.Visibility = Visibility.Collapsed;
            Sent12.Visibility = Visibility.Collapsed;
            Sent13.Visibility = Visibility.Collapsed;
            Sent14.Visibility = Visibility.Collapsed;
            Sent15.Visibility = Visibility.Collapsed;
            Sent16.Visibility = Visibility.Collapsed;
            Sent17.Visibility = Visibility.Collapsed;
            Sent18.Visibility = Visibility.Collapsed;
            Sent19.Visibility = Visibility.Collapsed;
            Sent20.Visibility = Visibility.Collapsed;
            Sent21.Visibility = Visibility.Collapsed;
            Sent22.Visibility = Visibility.Collapsed;
            Sent23.Visibility = Visibility.Collapsed;
            Sent24.Visibility = Visibility.Collapsed;
            Sent25.Visibility = Visibility.Collapsed;
            Sent26.Visibility = Visibility.Collapsed;

            Image1.Visibility = Visibility.Collapsed;
            Image2.Visibility = Visibility.Collapsed;
            Image3.Visibility = Visibility.Collapsed;
            Play1.Visibility = Visibility.Collapsed;
            Play2.Visibility = Visibility.Collapsed;

            Message1.Code.Text = "Oh, I'll come after...";
            Message2.Code.Text = "Got it!";
            StartMessage.User.Text = "Review it after lunch";
            Name.Text = "Ken";
            logger.Debug("User Ken chosen");
        }

        private void History_ButtonClick(object sender, RoutedEventArgs e)
            {
            new Hystory().ShowDialog();
            logger.Debug("Button History clicked");
            }

        private void People_ButtonClick(object sender, RoutedEventArgs e)
            {
            Unknown.Visibility = Visibility.Visible;
            Allison.Visibility = Visibility.Visible;
            Ken.Visibility = Visibility.Visible;
            Trace.Visibility = Visibility.Visible;
            logger.Debug("Button People clicked");
        }

        private void Contacts_ButtonClick(object sender, RoutedEventArgs e)
        {
            new Contacts().ShowDialog();
            logger.Debug("Button Contacts clicked");
        }

        private void Archive_ButtonClick(object sender, RoutedEventArgs e)
            {
            new Archive().ShowDialog();
            logger.Debug("Button Archive clicked");
        }

        private void Sound1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                player.SoundLocation = @"D:\Project\Login\Chat\Sounds\footsteps.wav";
                player.Load();
                player.Play();
                player.Dispose();
                logger.Debug("Sound of footsteps played");
            }

            catch (FileNotFoundException ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        private void Sound2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                player.SoundLocation = @"D:\Project\Login\Chat\Sounds\sound.wav";
                player.Load();
                player.Play();
                player.Dispose();
                logger.Debug("Indecipherable sound played");
            }

            catch (FileNotFoundException ex)
            {
                logger.Error(ex);
                throw;
            }
        }
    }
}
