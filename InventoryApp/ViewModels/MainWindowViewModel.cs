// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

#nullable enable
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using InventoryApp.Commands;
using InventoryApp.Files;
using InventoryApp.Models;

namespace InventoryApp.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        private ObservableCollection<Item> _inventory;
        private Item? _selectedItem;

        public ICommand AddCommand { get; set; }

        public MainWindowViewModel(IEnumerable<Item> inventory)
        {
            _inventory = new ObservableCollection<Item>(inventory);
            AddCommand = new RelayCommand(AddItem);

            _inventory.CollectionChanged += (s, e) => Save(s, null);
        }

        private void AddItem()
        {
            var item = new Item();
            _inventory.Add(item);
            SelectedItem = item;

        }

        public ObservableCollection<Item> Inventory
        {
            get => _inventory;
            set => SetField(ref _inventory, value);
        }

        public Item? SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != null)
                {
                    _selectedItem.PropertyChanged -= Save;
                }

                SetField(ref _selectedItem, value);

                if (_selectedItem != null)
                {
                    _selectedItem.PropertyChanged += Save;
                }
            }
        }

        public void Save(object sender, PropertyChangedEventArgs e)
        {
            var items = _inventory.ToArray();

            Task.Run(() => XmlFile.Save(items, "phones.xml"));
        }
    }

    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value) || propertyName == null)
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}