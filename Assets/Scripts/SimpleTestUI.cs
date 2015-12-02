using UnityEngine;
using System.Collections;

public class SimpleTestUI : MonoBehaviour {

    private BaseCharachterClass mage = new BaseMageClass();
    private BaseCharachterClass warrior = new BaseWarriorClass();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUILayout.Label(mage.CharacterClassName);
        GUILayout.Label(mage.CharacterClassDescription);
        GUILayout.Label(mage.Intelligence.ToString());
        GUILayout.Label(warrior.CharacterClassName);
        GUILayout.Label(mage.Intelligence.ToString());
        GUILayout.Label(warrior.CharacterClassDescription);
    }
}
