using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boutton_List : MonoBehaviour {

    public Button button;
    public GameObject list;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(listAppear);
    }

    void listAppear()
    {
        if (list.active)
            list.SetActive(false);
        else
            list.SetActive(true);
    }
}
