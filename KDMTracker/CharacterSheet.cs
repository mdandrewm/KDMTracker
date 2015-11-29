using System;

namespace KDMTracker
{
	public class CharacterSheet
	{
		string Name;
		bool IsMale;

		uint Survival;
		bool CanDodge;
		bool CanEncourage;
		bool CanSurge;
		bool CanDash;

		uint Movement;
		ModifiableStat Accuracy;
		ModifiableStat Strength;
		ModifiableStat Evasion;
		ModifiableStat Luck;
		ModifiableStat Speed;

		HitLocation Brain;
		HitLocation Head;
		HitLocation Arms;
		HitLocation Body;
		HitLocation Waist;
		HitLocation Legs;

		ProgressChain HuntXP;

		WeaponType ProficiencyChoice;
		ProgressChain WeaponProficiencyLevel;

		ProgressChain Courage;

		ProgressChain Understanding;

		Array<FightingArt> FightingArts;
		bool CanUseFightingArts;

		Array<Disorder> Disorders;

		bool SkipNextHunt;
		Array<AbilityAndImpariment> AbilitiesAndImpairments;


		public CharacterSheet ()
		{
		}
	}
}

