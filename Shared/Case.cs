using Einstein.BL.Contracts;
using Einstein.DL.SQLite;

namespace Einstein.BL
{
	/// <summary>
	/// Represents a list of all the cases
	/// </summary>
	public class CaseArchive : IBusinessEntity
	{
		public CaseArchive ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Story { get; set; }
		public string Plot { get; set; }
	}
}

