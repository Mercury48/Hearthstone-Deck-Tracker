﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hearthstone_Deck_Tracker.Controls.Stats.Constructed
{
	/// <summary>
	/// Interaction logic for ConstructedMatchupTable.xaml
	/// </summary>
	public partial class ConstructedMatchupTable : UserControl
	{
		public ConstructedMatchupTable()
		{
			InitializeComponent();
		}

		private void DataGridMatchups_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
