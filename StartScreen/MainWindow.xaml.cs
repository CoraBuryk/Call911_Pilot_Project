using Project.Log;
using StartScreen.Login;
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
using static Project.Script.IVariations;
using Project.Script;

namespace StartScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CreateUserViewModel create = new();
        NameAttribute nameAttribute = new();
        PasswordAttribute passwordAttribute = new();
        Logger<MainWindow> logger = new();

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                logger.Info("Login form screen started");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }

            InfoAboutAssembly info = new();
            info.Get();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (nameAttribute.Match(txtUsername.Text))
            {
                logger.Error(new NameLenghtException($"Incorrect length of username: {txtUsername.Text.Length}"));
                //throw new NameLenghtException();
                create.Name = txtUsername.Text;
                MessageBox.Show(nameAttribute.FormatErrorMessage($"Длина имени пользователя должна быть не менее 2 и не более 10 символов. Вы ввели:{txtUsername.Text.Length}"));
            }
            else
            {
                create.Name = txtUsername.Text;
                logger.Debug($"Name created {create.Name}");
            }

            if (passwordAttribute.IsValid(txtPassword.Password))
            {
                logger.Error(new PasswordLenghtException($"Incorrect length of password: {txtPassword.Password.Length}"));
                //throw new PasswordLenghtException();
                create.Password = txtPassword.Password;
                MessageBox.Show(passwordAttribute.FormatErrorMessage($"Длина пароля не должна быть меньше или превышать более 8 символов. Вы ввели:{txtPassword.Password.Length}"));
            }
            else 
            {
                create.Password = txtPassword.Password;
                logger.Debug("Password created");
            }


            if (create.Password.Length == 8 && create.Name.Length <= 10 && create.Name.Length >= 2)
            {

                Chat.MainWindow window = new();
                window.ShowDialog();
                logger.Info("Chat sceen opened");
            }
            else
            {
                logger.Error(new Exception($"Incorrect data. Chat didn't open"));
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            DragMove();
            logger.Info("Screen Start moved");
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            logger.Info("Application Start Screen closed");
        }
    }
}
