using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {

    public Transform itemsParent;

	Inventory inventory;

    InventorySlot[] slots;

    void Start () {
		inventory = Inventory.instance;
        //inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentInChildren<InventorySlot[]>();
	}
	
	void Update () {
		
	}
	
	void UpdateUI () {
        for (int i = 0; i < slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            } else
            {
                slots[i].ClearSlot();
            }
        }
	}
	
}
