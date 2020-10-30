// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

using System.Collections.Generic;
using InventoryApp.Models;


namespace InventoryApp.ViewModels
{
    public class DesignViewModel : MainWindowViewModel
    {
        public DesignViewModel() : base(GetDesignInventory()) { }

        public static IEnumerable<Item> GetDesignInventory()
        {
            var inventory = new List<Item>();
            inventory.Add(new Item { Name = "iPhone 12", Count = 2, Cost = 399.99m, Price = 499.99m, Description = @"The iPhone is a smartphone made by Apple that combines a computer, iPod, digital camera and cellular phone into one device." });
            inventory.Add(new Item { Name = "Pixel 5", Count = 7, Cost = 459.99m, Price = 599.99m, Description = @"A more affordable 5G phone with some flagship-level features manufactured by Google." });
            inventory.Add(new Item { Name = "Pixel 4a", Count = 5, Cost = 459.99m, Price = 599.99m, Description = @"A more affordable phone with some flagship-level features manufactured by Google." });
            inventory.Add(new Item { Name = "Pixel 4", Count = 3, Cost = 459.99m, Price = 599.99m, Description = @"A more affordable phone with some flagship-level features manufactured by Google." });

            return inventory;
        }

    }
}