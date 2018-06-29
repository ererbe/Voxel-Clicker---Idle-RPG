using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Dungeon/Enemy")]
public class Enemy : ScriptableObject
{

    public string enemyName = "New Enemy";

    public bool isBoss = false;

    public int EnemyLevel = 0;

    public float Armor = 0f;
    public float HP = 0f;
    public float CritChance = 0f;
    public float ChitMulti = 0f;
    public float DodgeChance = 0f;
    public float physicalDmg = 0f;
    public float AttackSpeed = 0f;

    public int FireDmg = 0;
    public int WaterDmg = 0;
    public int FrostDmg = 0;
    public int NatureDmg = 0;
    public int AirDmg = 0;
    public int EarthDmg = 0;
    public int MetalDmg = 0;
    public int ElectricDmg = 0;
    public int LightDmg = 0;
    public int DarkDmg = 0;
    public int BloodDmg = 0;

    public int FireResistance = 0;
    public int WaterResistance = 0;
    public int FrostResistance = 0;
    public int NatureResistance = 0;
    public int AirResistance = 0;
    public int EarthResistance = 0;
    public int MetalResistance = 0;
    public int ElectricResistance = 0;
    public int LightResistance = 0;
    public int DarkResistance = 0;
    public int BloodResistance = 0;

    public float LD_P_of_Max_HP = 0;
    public float LD_Value = 0;
    public float LD_P_of_DealtDmg = 0;
    public float Reg_Per_Sec = 0;
}
