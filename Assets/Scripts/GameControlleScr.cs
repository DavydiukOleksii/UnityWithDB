using UnityEngine.UI;
using UnityEngine;
using Assets.Scripts;
using System;

public class GameControlleScr : MonoBehaviour {

    public GameObject inputField;
    public GameObject outField;

    public void buttonEnterClick()
    {
        string finalyStr = "Don`t found product with this ID. Please, enter another ID.";
        try
        {
            int id = int.Parse(inputField.GetComponent<Text>().text);
            Product prod = DBManagerScr.getInstance().GetById(id);

            if (prod != null)
                finalyStr = "Id = " + prod.id.ToString() + "\nName: " + prod.name + "\nDescription: " + prod.description + "\n";
        }
        catch (Exception e)
        {
            finalyStr = "ID must consist only numbers!";
        }
        finally
        {
            outField.GetComponent<Text>().text = finalyStr;
        }
    }
}
