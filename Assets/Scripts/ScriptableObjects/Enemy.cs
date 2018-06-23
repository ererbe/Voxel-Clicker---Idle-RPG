using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Dungeon/Enemy")]
public class Enemy : ScriptableObject
{

    public string enemyName = "New Enemy";
    public GameObject enemyBody = null;

    public bool isBoss = false;

    public int EnemyLevel = 0;

    public float Armor = 0f;
    public float HP = 0f;
    public float CritChance = 0f;
    public float ChitMulti = 0f;
    public float DodgeChance = 0f;

    public int Fire;
    public int Water;
    public int Frost;
    public int Nature;
    public int Air;
    public int Metal;
    public int Electric;
    public int Light;
    public int Dark;
    public int Blood;

    public float LD_P_of_Max_HP;
    public float LD_Value;
    public float LD_P_of_DealtDmg;
}
