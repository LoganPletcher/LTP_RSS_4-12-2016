using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public Text PText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
            PauseGame();
    }

    void PauseGame ()
    {
        if(Cursor.visible)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            PText.text = "";
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            PText.text = "PAUSED";
        }
    }
}
