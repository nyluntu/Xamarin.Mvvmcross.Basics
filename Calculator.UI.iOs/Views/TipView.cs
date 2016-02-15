using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace Calculator.UI.iOs
{
	public partial class TipView : MvxViewController
	{
		public TipView () : base ("TipView", null)
		{
		}

		public new TipViewModel ViewModel {
			get {return (TipViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
			this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.SubTotal).Apply();
			this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();    
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


