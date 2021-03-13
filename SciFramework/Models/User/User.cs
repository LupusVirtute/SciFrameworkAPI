using SciFramework.Interfaces.User;
using System;
using SciFramework.Abstract.Database;

namespace SciFramework.Models.User
{
	public class User : Saveable,IUser
	{
		private string _uid;
		private string _nick;

		private string _email;
		private string _password;
		private string _salt;

		private string _b64ProfileImage;

		public string UID => _uid;
		public string NickName => _nick;
		public string B64Image => _b64ProfileImage;

		public bool IsPasswordCorrect(string password)
		{
			throw new NotImplementedException();
		}

		public bool SetImageProfile(string b64Image)
		{
			throw new NotImplementedException();
		}

		public bool ChangePassword(string newPassword)
		{
			throw new NotImplementedException();
		}

		public bool ChangeEmail(string email)
		{
			throw new NotImplementedException();
		}
	}
}