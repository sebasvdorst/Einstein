using Einstein.BL.Contracts;
using Einstein.DL.SQLite;

namespace Einstein.BL
{
	/// <summary>
	/// Represents the players profile
	/// </summary>
	public class MyInfo : User
	{
		public MyInfo ()
		{
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Picture { get; set; }


	}
}

