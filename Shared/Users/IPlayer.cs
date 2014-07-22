using Einstein.BL.Contracts;
using Einstein.DL.SQLite;

namespace Einstein.BL
{
	/// <summary>
	/// Represents a User.
	/// </summary>
	public interface Profile 
	{
		string Picture { get; set; }
		string Name { get; set; }
		int Experience { get; set; }
	}
}