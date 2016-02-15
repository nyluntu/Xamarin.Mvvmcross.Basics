using System;
using MvvmCross.Droid.Views;
using Android.App;
using Calculator;

namespace Calculator.UI.Droid
{
	[Activity(Label = "Tip", MainLauncher=true)]
	public class TipView : MvxActivity
	{
		public TipView ()
		{
		}

		public new TipViewModel ViewModel {
			get{ return (TipViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet() 
		{
			base.OnViewModelSet ();
			SetContentView (Resource.Layout.View_Tip);
		}
	}
}

