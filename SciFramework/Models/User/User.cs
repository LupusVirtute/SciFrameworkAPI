using SciFramework.Interfaces.User;
using System;
using SciFramework.Abstract.Database;
using Dapper.Contrib.Extensions;

namespace SciFramework.Models.User
{
    [Table("Users")]
    public class User : Saveable, IUser
	{
        [Table("Users")]
        public class Model
        {
            [ExplicitKey]
            public string UID { get; set; }
            public string NickName { get; set; }
            public string B64Image { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Salt { get; set; }

            public User ToUser()
            {
                return new User(UID, NickName, Email, Password, Salt, B64Image);
            }
        }
		private string _uid;
		private string _nick;
        
		private string _email;
		private string _password;
		private string _salt;

		private string _b64ProfileImage;

        [ExplicitKey]
        public string UID
        {
            get => _uid == null ? SetNewGuid().ToString() : _uid;
            set => _uid = value;
        }

        private Guid SetNewGuid()
        {
            Guid guid = Guid.NewGuid();
            _uid = guid.ToString();
            return guid;
        }

        public string NickName => _nick;
		public string B64Image => _b64ProfileImage;

        private User(string uid, string nick, string email, string password, string salt, string b64ProfileImage)
        {
            _uid = uid;
            _nick = nick;
            _email = email;
            _password = password;
            _salt = salt;
            _b64ProfileImage = b64ProfileImage;
        }

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
