using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace WorkingWithNavigation
{
	public partial class Page1Xaml : ContentPage
	{
		public Page1Xaml ()
		{
			InitializeComponent ();

			Debug.WriteLine("Page1Xaml");
		}

		~Page1Xaml()
		{
			Debug.WriteLine("~Page1Xaml");
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page2Xaml ());
		}
	}
}
