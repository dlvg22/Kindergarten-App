using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWindowSCR : MonoBehaviour {

    public static bool Paused = false;
    public GameObject PausedUI;
	

    public void ResumeBTN()
    {
        PausedUI.SetActive(false);
    }
     public void QuitBTN()
    {
        Application.Quit();
        Debug.Log("GAME EXIT");
    }
}
