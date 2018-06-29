using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

    private Image enemyHpBar;

    private float enemyMaxHP;
    private float enemyHP;
    private float oldHP;
    private float newHP;
    public bool canAttack = false;
    private float attackCooldown;
    private float passedTime;

    private int dogdeVar;

    public Enemy enemy;
    public PlayerManager playerManager;

    private void Start()
    {
        BattleStart();
    }

    public void BattleStart()
    {
        enemyMaxHP = enemy.HP;
        enemyHP = enemyMaxHP;
        attackCooldown = enemy.AttackSpeed;
        canAttack = true;
    }

    public void GetPhysicalDamage(float amount)
    {
        dogdeVar = Random.Range(1, 1001);
        if (dogdeVar >= enemy.DodgeChance)
        {
            if (amount - enemy.Armor >= 0)
            {
                enemyHP -= amount - enemy.Armor;
            }
            CheckDeath();
            OnEnemyHpChange();
        }
        else
        {
            Debug.Log("hit evaded"); //will be important in the future: sounds, text, maybe animation *WIP
        }
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
        OnEnemyHpChange();
    }

    public void OnEnemyHpChange()
    {
        Mathf.Lerp(oldHP, newHP, 2f);
    }

    void Update()
    {
        enemyHpBar.fillAmount = newHP / enemyMaxHP;
        enemyHpBar.color = Color.Lerp(Color.green, Color.red, (float)newHP / enemyMaxHP);
        passedTime += Time.deltaTime;
        if(passedTime >= attackCooldown && canAttack == true) {
            Attack();
        }
    }

    void CheckDeath()
    {
        if (enemyHP <= 0)
        {
            DungeonManager.enemysAlive--;
            Destroy(gameObject);
        }
    }

    void Attack()
    {
        if (enemy.physicalDmg != 0)
        {
            playerManager.GetPhysicalDamage(enemy.physicalDmg);
        }
        if (enemy.FireDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.FireDmg, "fi");
        }
        if (enemy.WaterDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.WaterDmg, "wa");
        }
        if (enemy.FrostDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.FrostDmg, "fr");
        }
        if (enemy.NatureDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.NatureDmg, "na");
        }
        if (enemy.AirDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.AirDmg, "ai");
        }
        if (enemy.EarthDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.EarthDmg, "ea");
        }
        if (enemy.MetalDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.MetalDmg, "me");
        }
        if (enemy.ElectricDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.ElectricDmg, "el");
        }
        if (enemy.LightDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.LightDmg, "li");
        }
        if (enemy.DarkDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.DarkDmg, "da");
        }
        if (enemy.BloodDmg != 0)
        {
            playerManager.GetElementalDamage(enemy.BloodDmg, "bl");
        }
        passedTime = 0f;
    }
}
