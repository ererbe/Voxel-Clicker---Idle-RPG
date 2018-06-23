using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {

	//shorts:
	//Exp -> Experience
	//HP -> Health Points
	//MP -> Mana Points
	//EP -> Energy Points
	//Rec -> Recovery
	//Crit -> Critical Hit
	//Deadly -> Deadly Hit
	//Multi -> Multiplicator
	//LD -> LifeDrain (per hit)
	//P -> Percent
	//Max -> Maximum / Maximal
	//Min -> Minimum / Minimal
	//Dmg -> Damage
	
	//--level and Exp--
	public static int Level;
	public static float PlayerExp;
	public static float PlayerRequiredExp;
	
	public static int StatUpgradePoints;
	public static int ElementUpgradePoints;
	
	//--Stats--
	// - final stats - (after the whole math)
	//Not stats but Important
	public static float Armor;
	public static float HP;
	public static float HP_Rec;
	public static float MP;
	public static float MP_Rec;
	public static float EP;
	public static float EP_Rec;
	
	//basic stats
	public static int Strenght;
	public static int Intelligence;
	public static int Dexterity;
	public static int Luck;
	public static int Wisdom;
	public static int Willpower;
	public static int Agility;
	public static int Focus;
	public static int Toughness;
	
	//special stats
	public static float CritMulti;
	public static float DeadlyMulti;
	public static float LD_P_of_Max_HP;
	public static float LD_Value;
	public static float LD_P_of_DealtDmg;
	
	//Elemental stats
	public static int Fire;
	public static int Water;
	public static int Frost; //Not Ice, Ice is Water + This one. Other: Frost,cold,frozen,freeze
	public static int Nature;
	public static int Air;  //wind
	public static int Metal;
	public static int Electric; //lightning
	public static int Light;
	public static int Dark;
	public static int Blood;
	
	
	// - stats -
	//multiplication stats
	public static float HP_Multi;
	public static float MP_Multi;
	public static float EP_Multi;
	public static float HP_Rec_Multi;
	public static float MP_Rec_Multi;
	public static float EP_Rec_Multi;
	
	//Base stats, upgradeable through level ups.
	public static int BaseStrenght;
	public static int BaseIntelligence;
	public static int BaseDexterity;
	public static int BaseLuck;
	public static int BaseWisdom;
	public static int BaseWillpower;
	public static int BaseAgility;
	public static int BaseFocus;
	public static int BaseToughness;
	
	public static int BaseFire;
	public static int BaseWater;
	public static int BaseCold;
	public static int BaseNature;
	public static int BaseAir;
	public static int BaseMetal;
	public static int BaseElectric;
	public static int BaseLight;
	public static int BaseDark;
	public static int BaseBlood;
	 
	//Race
	public static int RaceStrenght;
	public static int RaceIntelligence;
	public static int RaceDexterity;
	public static int RaceLuck;
	public static int RaceWisdom;
	public static int RaceWillpower;
	public static int RaceAgility;
	public static int RaceFocus;
	public static int RaceToughness;

	public static float RaceCritMulti;
	public static float RaceDeadlyMulti;
	public static float RaceLD_P_of_Max_HP;
	public static float RaceLD_Value;
	public static float RaceLD_P_of_DealtDmg;

	public static int RaceFire;
	public static int RaceWater;
	public static int RaceCold;
	public static int RaceNature;
	public static int RaceAir;
	public static int RaceMetal;
	public static int RaceElectric; 
	public static int RaceLight;
	public static int RaceDark;
	public static int RaceBlood;
	
	public static float RaceHP_Multi;
	public static float RaceMP_Multi;
	public static float RaceEP_Multi;
	public static float RaceHP_Rec_Multi;
	public static float RaceMP_Rec_Multi;
	public static float RaceEP_Rec_Multi;
	
	//Class
	public static int ClassStrenght;
	public static int ClassIntelligence;
	public static int ClassDexterity;
	public static int ClassLuck;
	public static int ClassWisdom;
	public static int ClassWillpower;
	public static int ClassAgility;
	public static int ClassFocus;
	public static int ClassToughness;

	public static float ClassCritMulti;
	public static float ClassDeadlyMulti;
	public static float ClassLD_P_of_Max_HP;
	public static float ClassLD_Value;
	public static float ClassLD_P_of_DealtDmg;

	public static int ClassFire;
	public static int ClassWater;
	public static int ClassCold;
	public static int ClassNature;
	public static int ClassAir;
	public static int ClassMetal;
	public static int ClassElectric; 
	public static int ClassLight;
	public static int ClassDark;
	public static int ClassBlood;
	
	public static float ClassHP_Multi;
	public static float ClassMP_Multi;
	public static float ClassEP_Multi;
	public static float ClassHP_Rec_Multi;
	public static float ClassMP_Rec_Multi;
	public static float ClassEP_Rec_Multi;
	
	//Weapon/Attacktype Level And Exp
	public static int BladeWeaponLevel;
	public static int BladeWeaponExp;
	public static int AxeWeaponLevel;
	public static int AxeWeaponExp;
	public static int HammerWeaponLevel;
	public static int HammerWeaponExp;
	public static int ThrowingWeaponLevel;
	public static int ThrowingWeaponExp;
	public static int BowLevel;
	public static int BowExp;
	public static int CrossbowLevel;
	public static int CrossbowExp;
	public static int ThrustLevel; //stoß
	public static int ThrustExp;
	public static int StrokeLevel; //schlag
	public static int StrokeExp;
	public static int ScytheTypeLevel;
	public static int ScytheTypeExp;
	public static int FistWeaponsLevel;
	public static int FistWeaponsExp;
//	public static int Staff //big one
//	public static int Staff
//	public static int Bihänder //zweihänder
//	public static int Bihänder
//	public static int Longbow
//	public static int Longbow
//	public static int Shortbow
//	public static int Shortbow
//	public static int Bladebow //klingenbogen
//	public static int Bladebow
//	public static int Crossbow
//	public static int Crossbow
//	public static int HeavyCrossbow //kurbel
//	public static int HeavyCrossbow
//	public static int Lance
//	public static int Lance
//	public static int Slingshot
//	public static int Slingshot
//	public static int GreatAxe //Großaxt
//	public static int GreatAxe
//	public static int halberd //Hellebarde
//	public static int halberd
//	public static int WarAxe
//	public static int WarAxe
//	public static int WarHammer //Kriegshammer oder Streithammer
//	public static int WarHammer
//	public static int Swordstaff
//	public static int Swordstaff
//	public static int Scythe //sense
//	public static int Scythe
//	public static int Estoc //Panzerbrecher
//	public static int Estoc
	
//	public static int Fist
//	public static int Fist
	
//	public static int Knuckleduster
//	public static int Knuckleduster
//	public static int Claw
//	public static int Claw
//	public static int Shuriken
//	public static int Shuriken
//	public static int ThrowingKnives
//	public static int ThrowingKnives
//	public static int ThrowingArrow
//	public static int ThrowingArrow
	
//	public static int Dagger
//	public static int Dagger
//	public static int Knive
//	public static int Knive
//	public static int ShortSword
//	public static int ShortSword
//	public static int Epee //Degen
//	public static int Epee
//	public static int Longsword
//	public static int Longsword
//	public static int Ceptre
//	public static int Ceptre
//	public static int Wand //small one
//	public static int Wand
//	public static int Whip //Peitsche
//	public static int Whip
//	public static int Club //Knüppel
//	public static int Club
//	public static int Claymore //breitschwert
//	public static int Claymore
//	public static int BattleAxe
//	public static int BattleAxe
//	public static int Scimitar
//	public static int Scimitar
//	public static int Sickle
//	public static int Sickle
//	public static int Nunchaku
//	public static int Nunchaku
//	public static int Xiphos
//	public static int Xiphos
//	public static int Gladius
//	public static int Gladius
//	public static int Rapier
//	public static int Rapier
//	public static int Backsword
//	public static int Backsword
//	public static int Katana
//	public static int Katana
//	public static int Falchion
//	public static int Falchion
	
//	public static int Grenade
//	public static int Grenade
//	public static int ThrowingPotion
//	public static int ThrowingPotion
//	public static int Flail //Flegel,Morgenstern
//	public static int Flail
//	public static int Mace //streitkolben
//	public static int Mace
//	public static int Chakram
//	public static int Chakram
//	public static int Boomerang
//	public static int Boomerang
//	public static int Javelin //Wurfspeer
//	public static int Javelin
//	public static int ThrowingAxe
//	public static int ThrowingAxe
//	public static int BastardSword
//	public static int BastardSword
//	public static int Tomahawk
//	public static int Tomahawk
//	public static int Mambele
//	public static int Mambele
	
//	public static int CrystallBall
//	public static int CrystallBall
//	public static int Book
//	public static int Book
//	public static int RoundShield
//	public static int RoundShield
//	public static int Scutum //Langschild aus Holz (Römisch)
//	public static int Scutum
//	public static int VShield
//	public static int VShield
//	public static int OvalShield
//	public static int OvalShield
//	public static int Buckler
//	public static int Buckler
	
//	public static int SummonMagic
//	public static int SummonMagic
//	public static int HealMagic
//	public static int HealMagic
//	public static int IllusionMagic
//	public static int IllusionMagic
//	public static int Buff-DebuffMagic
//	public static int Buff-DebuffMagic
//	public static int DestructionMagic
//	public static int DestructionMagic
	
	//other values
	public static bool HasSaveData;
}
