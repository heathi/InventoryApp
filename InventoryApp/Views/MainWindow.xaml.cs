// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

using System.Collections.Generic;
using InventoryApp.Files;
using InventoryApp.Models;
using InventoryApp.ViewModels;
using MahApps.Metro.Controls;

namespace InventoryApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var items = XmlFile.Load<List<Item>>("phones.xml");
            ViewModel = new MainWindowViewModel(items);
            this.DataContext = ViewModel;
        }
    }
}