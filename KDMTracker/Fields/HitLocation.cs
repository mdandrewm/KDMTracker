using System;

namespace KDMTracker
{
	public class HitLocation
	{
		string LocationName;
		uint Armor;
		bool HasLightInjury;
		bool LightlyInjured;
		bool HeavilyInjured;

		public HitLocation (string locationName, bool hasLightInjury)
		{
			LocationName = locationName;
			HasLightInjury = hasLightInjury;
		}

		public void ReduceArmor()
		{
			if (Armor > 0) {
				Armor--;
			}
		}
	}
}

