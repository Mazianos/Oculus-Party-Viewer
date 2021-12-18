﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Test.Views
{
    /// <summary>
    /// Interaction logic for main.xaml
    /// </summary>
    /// 


    public partial class main : UserControl
    {

        Player_Character pc;

        public main()
        {
            InitializeComponent();
        }

        private void createPlayerCard(Player_Character pc)
        {
            System.Windows.Controls.ScrollViewer sc_viwer = new ScrollViewer();
            sc_viwer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            System.Windows.Controls.StackPanel armorClass = createStackPanel("Armor Class", pc.ArmorClass);
            System.Windows.Controls.StackPanel thb = createStackPanel("To-Hit Bonus", pc.ToHit);
            System.Windows.Controls.StackPanel avgDmg = createStackPanel("Average Damage", pc.AverageDamage);
            System.Windows.Controls.StackPanel avgHeal = createStackPanel("Average Healing", pc.AverageHealing);
            System.Windows.Controls.StackPanel str_sv = createStackPanel("Strenght Save", pc.Saves[0]);
            System.Windows.Controls.StackPanel dex_sv = createStackPanel("Dexterity Save", pc.Saves[1]);
            System.Windows.Controls.StackPanel cst_sv = createStackPanel("Constitution Save", pc.Saves[2]);
            System.Windows.Controls.StackPanel int_sv = createStackPanel("Intelligence Save", pc.Saves[3]);
            System.Windows.Controls.StackPanel wis_sv = createStackPanel("Wisdom Save", pc.Saves[4]);
            System.Windows.Controls.StackPanel chr_sv = createStackPanel("Charisma Save", pc.Saves[5]);
            System.Windows.Controls.StackPanel avd = createStackPanel("Avoidance", pc.Avoidance);


            mainPanel.Children.Add(sc_viwer);
            
        }

        private System.Windows.Controls.StackPanel createStackPanel(string content, float value)
        {
            System.Windows.Controls.StackPanel sp = new StackPanel();
            System.Windows.Controls.RadioButton rb = new RadioButton();
            rb.Content = content;
            System.Windows.Controls.TextBox tb = new TextBox();
            tb.Text = value.ToString();
            sp.Children.Add(rb);
            sp.Children.Add(tb);
            return sp;

        }
    }
    
}
