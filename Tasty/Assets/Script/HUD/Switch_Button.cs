using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch_Button : MonoBehaviour {

    #region PRIVATE_MEMBERS
    private Button _button;
    #endregion

    #region PUBLIC_MEMBERS
    public GameObject instructions;
    public GameObject ingredients;
    #endregion
    // Use this for initialization
    void Start () {
        _button = this.GetComponent<Button>();
        _button.onClick.AddListener(SwitchIn);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SwitchIn()
    {
        ingredients.SetActive(instructions.activeSelf);
        instructions.SetActive(!instructions.activeSelf);
    }
}
