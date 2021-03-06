﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace Nebulosa
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Nebulosa.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=c8add0f5-8f01-4a44-89c1-d4a7003d591d;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
