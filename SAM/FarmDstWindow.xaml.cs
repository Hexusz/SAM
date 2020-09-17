using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SAM
{
    
    public partial class FarmDstWindow : MetroWindow
    {
        


        private List<Account> decryptedAccounts;
        public FarmDstWindow(List<Account> decryptedAccounts)
        {
            InitializeComponent();
            this.decryptedAccounts = decryptedAccounts;
            RefreshAccountsList();
        }

        private void RefreshAccountsList()
        {
            
            foreach (Account account in decryptedAccounts)
            {
                if(account.DstAccount)
                AccountDstlistBox.Items.Add(account.Name);
            }
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            MainWindow MW = new MainWindow();

            MW.Farm_Dst_Start();
        }

    }
}
