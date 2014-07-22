using System;
using System.Collections.Generic;
using Einstein.BL;


namespace Einstein.BL.Managers
{
	public static class CaseManager
	{
		static CaseManager ()
		{
		}

		public static Case GetCase(int id)
		{
			return DAL.LocalRepository.GetCase (id);
		}

		public static IList<Case> GetCases ()
		{
			return new List<Case> (DAL.LocalRepository.GetCases ());
		}

		public static int SaveCase(Case item)
		{
			return DAL.LocalRepository.SaveCase (item);
		}

		public static int DeleteCase(int id)
		{
			return DAL.LocalRepository.DeleteCase (id);
		}
	}
}
