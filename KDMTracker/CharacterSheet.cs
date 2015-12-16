using System;

namespace KDMTracker
{
	public class CharacterSheet
	{
		string Name = "";
		bool IsMale = false;

		uint Survival = 0;
		bool CanDodge = true;
		bool CanEncourage = false;
		bool CanSurge = false;
		bool CanDash = false;

		uint Movement = 5;
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

		WeaponType? ProficiencyChoice = null;
		ProgressChain WeaponProficiencyLevel;

		ProgressChain Courage;

		ProgressChain Understanding;

		FightingArt[] FightingArts = null;
		bool CanUseFightingArts = true;

		Disorder[] Disorders = null;

		bool SkipNextHunt = false;
		AbilityAndImpariment[] AbilitiesAndImpairments = null;


		public CharacterSheet()
		{
			Accuracy = new ModifiableStat ("Accuracy");
			Strength = new ModifiableStat ("Strength");
			Evasion = new ModifiableStat ("Evasion");
			Luck = new ModifiableStat ("Luck");
			Speed = new ModifiableStat ("Speed");

			Brain = new HitLocation ("Brain", false);
			Head = new HitLocation ("Head", false);
			Arms = new HitLocation ("Arms", true);
			Body = new HitLocation ("Body", true);
			Waist = new HitLocation ("Waist", true);
			Legs = new HitLocation ("Legs", true);

			HuntXP = new ProgressChain (new uint[]{2,6,10,15,16},16);

			WeaponProficiencyLevel = new ProgressChain (new uint[]{ 3, 8 }, 8);

			Courage = new ProgressChain (new uint[]{ 3, 9 }, 9);

			Understanding = new ProgressChain (new uint[]{ 3, 9 }, 9);
		}
	}
}

