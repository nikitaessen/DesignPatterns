using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Tables
{
	public class ModernTable : ITable
	{
		public ModernTable()
		{
			Console.WriteLine("Modern table created.");
		}

		public void TakeTeaParty()
		{
			throw new System.NotImplementedException();
		}
	}
}
