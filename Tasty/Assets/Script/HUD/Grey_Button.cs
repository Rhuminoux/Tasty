using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grey_Button : MonoBehaviour {
    public Color selected;

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(GreyButton);
	}
	
	// Update is called once per fram
    void GreyButton()
    {
        if (GetComponent<Image>().color == Color.white)
        {
            GetComponent<Image>().color = selected;
        }

        else
            GetComponent<Image>().color = Color.white;
    }
}
