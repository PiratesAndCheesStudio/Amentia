/**
* Handler for the item database
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class ItemDatabase : MonoBehaviour {

	public TextAsset itemInventory;
	public static List<BaseItem> inventoryItems = new List<BaseItem>();

	private List <Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>>();
	private Dictionary<string, string> inventoryDictionary;

	void Awake() {
		readItems();
		for(int i = 0; i < inventoryItemsDictionary.Count; i++) {
			inventoryItems.Add(new BaseItem(inventoryItemsDictionary[i]));
		}
	}

	public void readItems() {
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.LoadXml(itemInventory.text);
		XmlNodeList itemList = xmlDoc.GetElementsByTagName("Item");

		foreach(XmlNode itemInfo in itemList) {
			XmlNodeList itemContent = itemInfo.ChildNodes;
			inventoryDictionary = new Dictionary<string, string>();

			foreach(XmlNode content in itemContent) {

				switch (content.Name) {
					case "id":
						inventoryDictionary.Add("id", content.InnerText);
						break;
					case "item_name":
						inventoryDictionary.Add("item_name", content.InnerText);
						break;

					case "item_type":
						inventoryDictionary.Add("item_type", content.InnerText);
						break;
				}
			}

			inventoryItemsDictionary.Add(inventoryDictionary);
		}
	}
}
