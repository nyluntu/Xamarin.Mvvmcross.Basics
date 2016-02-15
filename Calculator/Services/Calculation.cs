using System;

namespace Calculator
{

	/// <summary>
	/// Calculation.
	/// 
	/// Tiedosto sisältää yksinkertaisen business logiikan ohjelmalle.
	/// </summary>
	public class Calculation : ICalculation
	{
		public Calculation ()
		{
		}

		#region ICalculation implementation

		public double TipAmount (double subTotal, double generosity)
		{
			return subTotal * ((double)generosity/100.0);
		}

		#endregion
	}
}

