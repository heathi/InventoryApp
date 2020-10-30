// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

using System;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace InventoryApp.Behaviors
{
    class ListViewScrollIntoView : Behavior<ListView>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.SelectionChanged += AssociatedObject_SelectionChanged;
        }

        void AssociatedObject_SelectionChanged(object sender,
            SelectionChangedEventArgs e)
        {
            var listView = sender as ListView;

            if (listView?.SelectedItem == null)
            {
                return;
            }

            void Action()
            {
                listView.UpdateLayout();

                if (listView.SelectedItem != null)
                {
                    listView.ScrollIntoView(listView.SelectedItem);
                }
            }

            listView.Dispatcher.BeginInvoke((Action)(Action));
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.SelectionChanged -= AssociatedObject_SelectionChanged;
        }
    }
}