using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Chairs
{
	public class ModernChair : IChair
	{
		public ModernChair()
		{
			Console.WriteLine("Modern chair created.");
		}

		public bool HasLegs()
		{
			throw new System.NotImplementedException();
		}

		public void SitOn()
		{
			throw new System.NotImplementedException();
		}
	}
}
