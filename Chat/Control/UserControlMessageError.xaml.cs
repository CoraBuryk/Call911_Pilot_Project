using Project.Log;
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

namespace Chat.Control
{
    /// <summary>
    /// Interaction logic for UserControlMessageError.xaml
    /// </summary>
    public partial class UserControlMessageError : System.Windows.Controls.UserControl
    {
        Logger<UserControlMessageReceived> logger = new();
        public UserControlMessageError()
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
            logger.Debug("UserControlMessageError started");
        }
    }
}
