using SciFramework.Interfaces.Partner;
using System;
using SciFramework.Abstract.Database;

namespace SciFramework.Models.Partner
{
	public class Partner : Saveable,IPartner
	{

		private string _name;
		private string _description;
        private string _b64PartnerIcon;

		public string Name => _name;
		public string Description => _description;
        public string B64Image => _b64PartnerIcon;

		public Partner(string name,string description,string partnerIcon)
		{
			this._name = name;
			this._description = description;
            this._partnerIcon = partnerIcon;
		}



		
	}
}

