using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	
	public static Inventory instance;
	
	void Awake () {
		instance = this;
	}
	
	public int space = 20;
	
	public List<Item> items = new List<Item>();
	
	public void Add (Item item) {
		if (items.Count >= space) {
			Debug.Log("Inventory full!");
			return;
		}
		items.Add(item);
	}
	
	public void Remove(Item item) {
		items.Remove(item);
	}
	
}
