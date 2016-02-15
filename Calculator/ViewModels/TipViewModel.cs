using System;
using MvvmCross.Core.ViewModels;

namespace Calculator
{
	/// <summary>
	/// Tip view model.
	/// 
	/// ViewModel luokka, joka on näkymää vastaava luokka ja sisältää
	/// näkymälle oleelliset ominaisuudet ja kentät.
	/// </summary>
	public class TipViewModel : MvxViewModel
	{

		private readonly ICalculation _calculation;

		// Luokka rakennetaan käyttäen ICalculation toteutusta.
		public TipViewModel (ICalculation calculation)
		{
			_calculation = calculation;
		}

		// Rakentamisen jälkeen luokka alustetaan oletusarvoilla.
		public override void Start() {
			_subTotal = 100;
			_generosity = 10;
			Recalculate ();
			base.Start ();
		}

		private double _subTotal;
		public double SubTotal {
			get {return _subTotal;}
			set { _subTotal = value; RaisePropertyChanged (() => SubTotal); Recalculate (); }
		}

		private int _generosity;
		public int Generosity {
			get { return _generosity; }
			set { _generosity = value; RaisePropertyChanged (() => Generosity); Recalculate (); }
		}
	
		private double _tip;
		public double Tip {
			get { return _tip; }
			private set { _tip = value; RaisePropertyChanged (() => Tip); }
		}

		private void Recalculate() {
			Tip = _calculation.TipAmount (SubTotal, Generosity);
		}
	}
}

