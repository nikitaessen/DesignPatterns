using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Sofas
{
	public class ModernSofa : ISofa
	{
		public ModernSofa()
		{
			Console.WriteLine("Modern chair created.");
		}

		public bool HasLegs()
		{
			throw new System.NotImplementedException();
		}

		public void LayOn()
		{
			throw new System.NotImplementedException();
		}
	}
}
