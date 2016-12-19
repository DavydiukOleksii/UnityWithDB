using UnityEngine;
using UnityEngine.UI;

public class ClickBtnScr : MonoBehaviour {

    public GameObject inputField;
    public GameObject outField;

    private void buttonEnterClick()
    {
        int id = int.Parse(inputField.GetComponent<Text>().text);

        outField.GetComponent<Text>().text = id.ToString();
    }

    
}
