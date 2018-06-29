using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

    private Image playerHpBar;

    private float playerMaxHP;
    private float playerHP;
    private float oldHP;
    private float newHP;
    public bool canAttack = false;
    private float attackCooldown;
    private float passedTime;

    private int dogdeVar;
    //   public Player player; dont know if needed in the future
    public EnemyManager enemyManager;

    private void Start()
    {
        BattleStart();
    }

    public void BattleStart()
    {
        playerMaxHP = Player.HP;
        playerHP = playerMaxHP;
        canAttack = true;
    }

    public void GetPhysicalDamage(float amount)
    {
        dogdeVar = Random.Range(1, 1001);
 //       if (DogdeVar >= enemy.DodgeChance) *WIP, first we must load the stats °-^
 //       {
            if (amount - Player.Armor >= 0)
            {
                playerHP -= amount - Player.Armor;
            }
        CheckDeath();
        OnPlayerHpChange();
        //       }
        //       else
        //       {
        //           Debug.Log("hit evaded"); //will be important in the future: sounds, text, maybe animation *WIP
        //       }
    }

    public void GetElementalDamage(float amount, string element)
    {
        if (element == "fi")
        {

        }
        else if (element == "wa")
        {

        }
        else if (element == "fr")
        {

        }
        else if (element == "na")
        {

        }
        else if (element == "ai")
        {

        }
        else if (element == "ea")
        {

        }
        else if (element == "me")
        {

        }
        else if (element == "el")
        {

        }
        else if (element == "li")
        {

        }
        else if (element == "da")
        {

        }
        else if (element == "bl")
        {

        }
        CheckDeath();
        OnPlayerHpChange();
    }

    public void OnPlayerHpChange()
    {
        Mathf.Lerp(oldHP, newHP, 2f);
    }

    void Update()
    {
        playerHpBar.fillAmount = newHP / playerMaxHP;
        playerHpBar.color = Color.Lerp(Color.green, Color.red, (float)newHP / playerMaxHP);
        passedTime += Time.deltaTime;
        if (passedTime >= attackCooldown && canAttack == true)
        {
            Attack();
        }
    }

    void CheckDeath()
    {
        if (playerHP <= 0)
        {
            Destroy(gameObject);
            GameManager.EndDungeon();
        }
    }

    void Attack()
    {
        if (Player.PhysicalDmg != 0)
        {
            enemyManager.GetPhysicalDamage(Player.PhysicalDmg);
        }
        if (Player.FireDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.FireDmg, "fi");
        }
        if (Player.WaterDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.WaterDmg, "wa");
        }
        if (Player.FrostDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.FrostDmg, "fr");
        }
        if (Player.NatureDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.NatureDmg, "na");
        }
        if (Player.AirDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.AirDmg, "ai");
        }
        if (Player.EarthDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.EarthDmg, "ea");
        }
        if (Player.MetalDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.MetalDmg, "me");
        }
        if (Player.ElectricDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.ElectricDmg, "el");
        }
        if (Player.LightDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.LightDmg, "li");
        }
        if (Player.DarkDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.DarkDmg, "da");
        }
        if (Player.BloodDmg != 0)
        {
            enemyManager.GetElementalDamage(Player.BloodDmg, "bl");
        }
        passedTime = 0f;
    }

}
