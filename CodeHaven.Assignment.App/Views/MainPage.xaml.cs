using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CodeHaven.Assignment.App.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SideBarNavView.SelectedItem = SideBarNavView.MenuItems.ElementAt(1);
        }

        private void SideBarNavigation()
        {
            NavigationViewItem itemContent = (NavigationViewItem)SideBarNavView.SelectedItem;

            if (itemContent != null)
            {
                switch (itemContent.Tag)
                {
                    case "Farmers":
                        ContentFrame.Navigate(typeof(FarmersPage));
                        break;
                }
            }
        }

        private void SideBarNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            SideBarNavigation();
        }
    }
}
