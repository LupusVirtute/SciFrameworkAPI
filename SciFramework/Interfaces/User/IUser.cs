namespace SciFramework.Interfaces.User
{
	public interface IUser
	{
		/// <summary>
		/// Unique user ID String 32 chars long
		/// </summary>
		string UID { get; }

		/// <summary>
		/// User nick name
		/// </summary>
		string NickName { get; }
		/// <summary>
		/// User email
		/// </summary>
		string Email { get; }

		/// <summary>
		/// B64 Image string
		/// </summary>
		string B64Image { get; }

		/// <summary>
		/// Checks whether given password after hashing is same hashed password
		/// </summary>
		/// <param name="password">Bare password value to check</param>
		/// <returns>Whether <b>password</b> after hashing is correct password</returns>
		bool IsPasswordCorrect(string password);

		/// <summary>
		/// Sets b64 string image for profile
		/// </summary>
		/// <param name="b64Image">B64 image to replace profile</param>
		/// <returns></returns>
		bool SetImageProfile(string b64Image);

		/// <summary>
		/// Replaces old password with new password
		/// </summary>
		/// <param name="newPassword">new password to set</param>
		/// <returns>whether password was changed successfully</returns>
		bool ChangePassword(string newPassword);

		/// <summary>
		/// Replaces old email with new email
		/// </summary>
		/// <param name="newEmail">new email to set</param>
		/// <returns>whether email was changed successfully</returns>
		bool ChangeEmail(string email);
	}
}