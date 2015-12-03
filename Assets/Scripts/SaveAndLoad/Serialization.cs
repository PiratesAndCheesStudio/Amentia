/**
* Serialization class for our save games
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Serialization  {

	public static BinaryFormatter binaryFormatter = new BinaryFormatter ();

	public static void save(string key, object value) {
		MemoryStream memoryStream = new MemoryStream ();
		binaryFormatter.Serialize(memoryStream, value);
		string temp = System.Convert.ToBase64String(memoryStream.ToArray());
		PlayerPrefs.SetString(key, temp);
	}

	public static object load() {

	}
}
