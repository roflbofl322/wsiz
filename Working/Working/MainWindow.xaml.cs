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
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace Working
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
         string[] commands = new string[]
    {
        "get-process"
        ,"get-service"
        ,"get-command"
        ,"get-hotfix"
        ,"get-psdrive"
        ,"get-netadapter"

    };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PowerShell objPowerShell = PowerShell.Create();

            if (rdbtGetProcess.IsChecked == true)
            {
                objPowerShell.AddCommand("get-process");
                Collection<PSObject> results = objPowerShell.Invoke();
                foreach (PSObject result in results)
                {
                    txtOutput.Text += result + "\n";
                }

            }

        }
    }
}
