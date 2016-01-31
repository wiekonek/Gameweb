﻿using System;
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

namespace GAMEWEB.Controlls.Presenters {
    /// <summary>
    /// Interaction logic for ClosableTabHeader.xaml
    /// </summary>
    public partial class ClosableTabHeader : UserControl {
        public ClosableTabHeader(string tabName, UserControl tab) {
            InitializeComponent();
            labelName.Content = tabName;
            this.tab = tab;
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e) {
            App.MainWindowManager.RemoveTab(tab);
        }

        UserControl tab;
    }
}
