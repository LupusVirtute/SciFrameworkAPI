using System;
using SciFramework.Abstract.Database;

namespace SciFramework.Models.Partner
{
	public class Partner : Saveable
    {

		private string _name;
		private string _description;



		public string name
		{
			get => _name;
			set => _name = value;
		}

		public string description
        {
			get => _description;
			set => _description = value;
        }

		public Partner(string name,string description)
		{
			this._name = name;
			this._description = description;
		}

		
	}
}

