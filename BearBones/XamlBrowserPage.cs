﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BearBones
{
	public partial class XamlBrowserPage : ContentPage
	{
		public XamlBrowserPage(string xaml)
		{
			InitializeComponent();
			label.Text = xaml;
		}
	}
}

