using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Chairs
{
	public class DesignedChair : IChair
	{
		public DesignedChair()
		{
			Console.WriteLine("Designed chair created.");
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
