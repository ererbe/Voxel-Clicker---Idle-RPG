using UnityEngine;

public class GameManager : MonoBehaviour {

    public DungeonManager dungeonManager;

    public GameObject mainCam;

    public GameObject mainScreenMenu;
    public GameObject fightScreenMenu;

    public GameObject[] dungeons;

    public void StartDungeon (int DungeonID)
    {
        mainScreenMenu.SetActive(false);
        fightScreenMenu.SetActive(true);
        dungeons[DungeonID].SetActive(true);
        dungeonManager.activeDungeon = dungeons[DungeonID].GetComponent<Dungeon>();
        //spawn player here *WIP
        //set all the stats *WIP
        mainCam.SetActive(false);
        dungeonManager.StartBattle();
    }

    public static void EndDungeon()
    {
        for (int i = 0; i < dungeons.Length; i++)
        {
            dungeons[i].SetActive(false);
        }
        fightScreenMenu.SetActive(false);
        mainScreenMenu.SetActive(true);
        // *WIP
    }

}
