// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

namespace InventoryApp.Models
{
    public class Item : NotifyPropertyChangedBase
    {
        private string _name;
        private string _description;
        private uint _count;
        private decimal _cost;
        private decimal _price;

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }

        public uint Count
        {
            get => _count;
            set => SetField(ref _count, value);
        }

        public decimal Cost
        {
            get => _cost;
            set => SetField(ref _cost, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetField(ref _price, value);
        }

    }
}
