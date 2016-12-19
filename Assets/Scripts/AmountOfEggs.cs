using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmountOfEggs : MonoBehaviour {

    private Text _text;

	// Use this for initialization
	void Start () {
        _text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        _text.text = "Special Eggs: " + Eggs.specialEggs;
	}
}
