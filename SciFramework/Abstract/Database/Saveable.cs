using SciFramework.Interfaces.Database;

namespace SciFramework.Abstract.Database
{
	public abstract class Saveable : ISaveable
	{
		private bool _status;

		public bool Status
		{
			set => _status = value;
			get => _status;
		}

		public void FlipStatus()
		{
			_status = !_status;
		}
	}
}