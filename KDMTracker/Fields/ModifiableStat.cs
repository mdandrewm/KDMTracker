using System;

namespace KDMTracker
{
	public class ModifiableStat
	{
		string StatName;
		int StatValue;
		int StatDelta;

		public ModifiableStat (string name)
		{
			StatName = name;
			StatValue = 0;
			StatDelta = 0;
		}

		public ModifiableStat (string name, int statValue, int statDelta)
		{
			StatName = name;
			StatValue = statValue;
			StatDelta = statDelta;
		}
	}
}

