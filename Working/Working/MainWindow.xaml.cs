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
        "Get-Process"
        ,"Get-Service"
        ,"Get-Command"
        ,"Get-Hotfix"
        ,"Get-Psdrive"
        ,"Get-Netadapter"

    };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PowerShell objPowerShell = PowerShell.Create();
            
                
                objPowerShell.AddCommand(cmb_btn_select_command.SelectedItem.ToString());
                Collection<PSObject> results = objPowerShell.Invoke();
                foreach (PSObject result in results)
                {
                    txtOutput.Text += result + "\n" ;
                }
                

            
            

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // Item m = cmb_btn_select_command.SelectedItem;
            
        }

        private void Cmb_btn_select_command_DropDownOpened(object sender, EventArgs e)
        {
           
        }

        private void Cmb_btn_select_command_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string command in commands)
            {
                cmb_btn_select_command.Items.Add(command);
            }
        }

        private void TestOtput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
