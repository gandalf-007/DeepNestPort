﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DeepNestPort.Core
{
    /// <summary>
    /// Interaction logic for RibbonMenuWpf.xaml
    /// </summary>
    public partial class RibbonMenuWpf : System.Windows.Controls.UserControl
    {
        public RibbonMenuWpf()
        {
            InitializeComponent();
            RibbonWin.SelectionChanged += RibbonWin_SelectionChanged;
            RibbonWin.KeyDown += RibbonWin_KeyDown;
            RibbonWin.Loaded += RibbonWin_Loaded;
        }

        private void RibbonWin_Loaded(object sender, RoutedEventArgs e)
        {
            Grid child = VisualTreeHelper.GetChild((DependencyObject)sender, 0) as Grid;
            if (child != null)
            {
                child.RowDefinitions[0].Height = new GridLength(0);
            }
        }

        private void RibbonWin_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                if (RibbonWin.SelectedIndex != RibbonWin.Items.Count - 1)
                {
                    RibbonWin.SelectedIndex++;
                }
                else
                {
                    RibbonWin.SelectedIndex = 0;
                }
            }
        }

        static Form1 Form => Form1.Form;
        public event Action TabChanged;
        private void RibbonWin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabChanged?.Invoke();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            Form.AddDetail();
        }
        private void Run_Click(object sender, RoutedEventArgs e)
        {
            Form.RunNest();
        }

        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            Form.StopNesting();
        }

        private void RibbonButton_Click_2(object sender, RoutedEventArgs e)
        {
            Form.Export();
        }

        private void RibbonButton_Click_3(object sender, RoutedEventArgs e)
        {
            Form.ZoomIn();
        }

        private void RibbonButton_Click_4(object sender, RoutedEventArgs e)
        {
            Form.ZoomOut();
        }

        private void RibbonButton_Click_5(object sender, RoutedEventArgs e)
        {
            Form.FitAll();
        }

        
        private void RibbonButton_Click_6(object sender, RoutedEventArgs e)
        {
            Form.FitNextSheet();
        }

        private void RibbonButton_Click_7(object sender, RoutedEventArgs e)
        {
            Form.ExportAll();
        }

        private void RibbonButton_Click_8(object sender, RoutedEventArgs e)
        {
            Form.SwitchSettingsPanel();
        }

        private void RibbonToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Form.ColorsView(true);
        }

        private void colorsToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            Form.ColorsView(false);
        }

        private void borderScroll_Unchecked(object sender, RoutedEventArgs e)
        {
            Form.BorderScroll(false);
        }

        private void borderScroll_Checked(object sender, RoutedEventArgs e)
        {
            Form.BorderScroll(true);
        }

        private void RibbonButton_Click_9(object sender, RoutedEventArgs e)
        {
            Form.ShowNestsList();
        }

        private void RibbonButton_Click_10(object sender, RoutedEventArgs e)
        {
            Form.Report();
        }
    }
}
