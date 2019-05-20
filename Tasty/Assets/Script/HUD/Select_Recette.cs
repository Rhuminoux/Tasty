using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Recette : MonoBehaviour {

    #region PUBLIC_ATTRIBUTES
    public Button button;
    public GameObject recette;
    public GameObject instructions;
    public GameObject ingredients;
    public List<GameObject> ingList;
    #endregion PRIVATE_ATTRIBUTES

    #region PRIVATE_ATTRIBUTES
    private GameObject newIns;
    private GameObject newIng;
    #endregion PRIVATE_ATTRIBUTES

    void Start () {
        button.onClick.AddListener(LoadRecette);
	}
	
	void Update () {
		
	}

    void LoadRecette()
    {
        //Destoying the old one
        int i = ingredients.transform.childCount;
        if (instructions.transform.childCount > 0)
            Destroy(instructions.transform.GetChild(0).gameObject);
        while ( i != 0)
        {
            --i;
            Destroy(instructions.transform.GetChild(0).gameObject);
        }

        //Create new one
        newIns = Instantiate(recette, new Vector3(0, 0, 0), new Quaternion());
        newIns.transform.SetParent(instructions.transform);
        newIns.GetComponent<RectTransform>().localPosition = new Vector3(35, -56, 0);
        foreach (GameObject obj in ingList)
        {
            newIng = Instantiate(obj, new Vector3(0, 0, 0), new Quaternion());
            newIng.transform.SetParent(ingredients.transform);
            newIng.GetComponent<RectTransform>().localPosition = new Vector3(-25, 130 - ((ingList.IndexOf(obj) + 1) * 80f), 0);
        }
    }
}
