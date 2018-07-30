using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Sofas
{
	public class DesignedSofa : ISofa
	{
		public DesignedSofa()
		{
			Console.WriteLine("Designed sofa created.");
		}

		public bool HasLegs()
		{
			throw new NotImplementedException();
		}

		public void LayOn()
		{
			throw new NotImplementedException();
		}
	}
}
