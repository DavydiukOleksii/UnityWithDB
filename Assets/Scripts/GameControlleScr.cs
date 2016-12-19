using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts;

public class GameControlleScr : MonoBehaviour {

    public GameObject inputField;
    public GameObject outField;

    public void buttonEnterClick()
    {
        int id = int.Parse(inputField.GetComponent<Text>().text);

        List<Product> prod = new List<Product>();

        prod = DBManagerScr.getInstance().GetById(id);

        string finalyStr = "Enter corect product ID!";

        foreach (var pr in prod)
        {
            if(id == pr.id)
                finalyStr = "Id = " + pr.id.ToString() + "\nName: " + pr.name + "\nDescription: " + pr.description + "\n";
        }

        outField.GetComponent<Text>().text = finalyStr;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
