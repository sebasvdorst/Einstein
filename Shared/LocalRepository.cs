using System;

namespace Einstein.DAL
{
	public class CaseRepository
	{
		DL.LocalDatabase db = null;
		protected static string dbLocation;
		protected static CaseRepository me;

		static CaseRepository ()
		{
			me = new CaseRepository ();
		}

		protected CaseRepository()
		{
			//set the db db location
			dbLocation = DatabaseFilePath;

			//instantiate the database
			db = new Einstein.DL.LocalDatabase (dbLocation);
		}

		public static string DatabaseFilePath
		{
			get
			{

			}
		}
	}
}

