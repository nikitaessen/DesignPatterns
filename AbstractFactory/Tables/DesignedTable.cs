using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Tables
{
	public class DesignedTable : ITable
	{
		public DesignedTable()
		{
			Console.WriteLine("Designed table created.");
		}

		public void TakeTeaParty()
		{
			throw new System.NotImplementedException();
		}
	}
}
