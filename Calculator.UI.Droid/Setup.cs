using System;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using Android.Content;

namespace Calculator.UI.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup (Context applicationContext)
			: base(applicationContext)
		{
		}
	
		protected override IMvxApplication CreateApp()
		{
			return new App ();
		}
	}


}

