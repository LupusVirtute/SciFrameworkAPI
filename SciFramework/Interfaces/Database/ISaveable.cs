namespace SciFramework.Interfaces.Database
{
	/// <summary>
	/// Functions as interface to check whether it is needed to update value in database<br></br>
	/// update value in database based only on the status
	/// </summary>
	public interface ISaveable
	{
		/// <summary>
		/// Flips status to save database
		/// </summary>
		void FlipStatus();

		/// <summary>
		/// Status whether to save object to database or not in next update loop
		/// </summary>
		bool Status
		{
			get;
			set;
		}
	}
}