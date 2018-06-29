using UnityEngine;

public class DungeonManager : MonoBehaviour {

    public FightManager fightManager;
    public EnemyManager enemyManager;
    public PlayerManager playerManager;

    public static int enemysAlive = 0;

    private int enemyCount;
    private int enemysLeft;
    public Transform playerPosition;

    public Dungeon activeDungeon;

    public void NewDungeonStart ()
    {
        enemysLeft = activeDungeon.lenght;
        StartBattle();
    }

	public void StartBattle () {
        enemyManager.BattleStart();
        playerManager.BattleStart();
	}
	
    public void EnemyDied ()
    {
        MoveForward();
    }

    void MoveForward ()
    {
        playerManager.canAttack = false;
        //playerPos + 7f... animation.... blah blah blah *WIP
        SpawnEnemy();
    }

    void SpawnEnemy ()
    {
        if (enemysLeft == 1)
        {
            Instantiate(activeDungeon.boss, new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z + 7f), playerPosition.rotation);
        } else
        {
            enemyCount = Random.Range(0, activeDungeon.enemys.Length);
            Instantiate(activeDungeon.enemys[enemyCount], new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z + 7f), playerPosition.rotation);
        }
        enemysLeft--;
        enemyManager.playerManager = playerManager;
        playerManager.enemyManager = enemyManager;
        StartBattle();
    }
}
