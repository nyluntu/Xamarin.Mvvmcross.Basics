using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Calculator
{
	/// <summary>
	/// App.
	/// 
	/// Luokka huolehtii ohjelman alustuksesta ja kertoo ohjelmalle
	/// mitä toteutuksia luokista käytetään. Maaginen IoC-tapahtuu
	/// tässä luokassa.
	/// 
	/// Luokka rekisteröi tarvitsemansa luokat.
	/// </summary>
	public class App : MvxApplication
	{
		public App ()
		{
			// Kun ICalculation toteutusta kutsutaan ohjelmassa, huolehtii
			// rekisteröinti, että Calcutation toteutus luodaan.
			Mvx.RegisterType<ICalculation, Calculation> ();

			// Kun joku ohjelman osa kutsuu ImvxAppStart viittausta,
			// huolehtii rekisteröinti, että luokan instanssi luodaan vain 
			// kerran. Määrittää mikä on ensimmäinen viewmodel, joka aukeaa.
			var appStart = new MvxAppStart<TipViewModel> ();
			Mvx.RegisterSingleton<IMvxAppStart> (appStart);
		}
	}
}

