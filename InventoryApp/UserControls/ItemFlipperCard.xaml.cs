// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

using System.Windows;
using System.Windows.Controls;


namespace InventoryApp.UserControls
{
    public partial class ItemFlipperCard : UserControl
    {
        public static DependencyProperty ItemNameProperty = DependencyProperty.Register(nameof(ItemName), typeof(string), typeof(ItemFlipperCard));

        public string ItemName
        {
            get => (string)GetValue(ItemNameProperty);
            set => SetValue(ItemNameProperty, value);
        }

        public static DependencyProperty ItemDescriptionProperty = DependencyProperty.Register(nameof(ItemDescription), typeof(string), typeof(ItemFlipperCard));

        public string ItemDescription
        {
            get => (string)GetValue(ItemDescriptionProperty);
            set => SetValue(ItemDescriptionProperty, value);
        }

        public static DependencyProperty ItemCountProperty = DependencyProperty.Register(nameof(ItemCount), typeof(uint), typeof(ItemFlipperCard));

        public uint ItemCount
        {
            get => (uint)GetValue(ItemCountProperty);
            set => SetValue(ItemCountProperty, value);
        }

        public static DependencyProperty ItemCostProperty = DependencyProperty.Register(nameof(ItemCost), typeof(decimal), typeof(ItemFlipperCard));

        public decimal ItemCost
        {
            get => (decimal)GetValue(ItemCostProperty);
            set => SetValue(ItemCostProperty, value);
        }

        public static DependencyProperty ItemPriceProperty = DependencyProperty.Register(nameof(ItemPrice), typeof(decimal), typeof(ItemFlipperCard));

        public decimal ItemPrice
        {
            get => (decimal)GetValue(ItemPriceProperty);
            set => SetValue(ItemPriceProperty, value);
        }

        public ItemFlipperCard()
        {
            InitializeComponent();
        }
    }
}
