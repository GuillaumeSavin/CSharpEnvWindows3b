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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EnvWindows3b
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            TextBlock stackText = new TextBlock();
            Button bouton1 = new Button();
            Button bouton2 = new Button();
            Button bouton3 = new Button();

            stackText.Text ="Alignment, Margin et Padding Simple";
            stackText.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            
            bouton1.Content = "Button 1";           


            bouton2.Content = "Button 2";

            bouton3.Content = "Button 3";
            bouton3.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            bouton3.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            bouton3.HorizontalAlignment = HorizontalAlignment.Left;
            bouton3.VerticalAlignment = VerticalAlignment.Bottom;

            //StackPanel.Margin = new Thickness(72, 426, 10.8, 10);
            StackPanel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            StackPanel.Background = new SolidColorBrush(Windows.UI.Colors.Beige);
            StackPanel.Children.Add(stackText);
            StackPanel.Children.Add(bouton1);
            StackPanel.Children.Add(bouton2);
            StackPanel.Children.Add(bouton3);
            StackPanel.Margin = new Thickness(0, 10, -10, 0);
            StackPanel.Padding = new Thickness(0, 20, 50, 10);
            //StackPanel.Children.Add(new TextBlock().Text("Alignment, Margin et Padding Simple"));
        }
    }
}
