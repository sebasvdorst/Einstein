using System;
using System.Collections.Generic;
using Einstein.BL;

namespace Einstein.BL.Managers
{
	public class UserManager
	{
		static UserManager ()
		{
		}
			
		public static Player GetPlayer(int id)
		{
			return DAL.LocalRepository.GetPlayer (id);
		}

		public static IList<Player> GetPlayers ()
		{
			return new List<Player> (DAL.LocalRepository.GetPlayers ());
		}

		public static int SavePlayer (Player item)
		{
			return DAL.LocalRepository.SavePlayer (item);
		}

		public static int DeletePlayer(int id)
		{
			return DAL.LocalRepository.DeletePlayer (id);
		}
	}
}

