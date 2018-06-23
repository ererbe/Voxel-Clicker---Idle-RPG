using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {

    private Image EnemyHpBar;

    private float EnemyMaxHP;
    private float EnemyHP;
    private float OldHP;
    private float NewHP;

    public void GetDamage (float amount)
    {
        EnemyHP -= amount;
        CheckDeath();
        OnEnemyHpChange();
    }

	public void OnEnemyHpChange () {
        Mathf.Lerp(OldHP, NewHP, 2f);
    }

    void Update()
    {
        EnemyHpBar.fillAmount = NewHP / EnemyMaxHP;
        EnemyHpBar.color = Color.Lerp(Color.green,Color.red,(float) NewHP / EnemyMaxHP);
    }

    void CheckDeath ()
    {
        if (EnemyHP <= 0)
        {
            FightManager.enemysAlive--;
            Destroy(gameObject);
        }
    }
}
