﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSCR : MonoBehaviour {
    public Text Username;
    string user = "Character";
    public GameObject SettingsMenu;
    void Start() {

    //  Debug.Log(PlayerPrefs.GetString(user).ToString());
      Username.text = PlayerPrefs.GetString(user).ToString();
    }
    void Update()
    {
    


    }
    public void PlayBTN()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StatsBTN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void QuitBTN()
    {
           SettingsMenu.SetActive(true);
            Debug.Log("Paused..");
    }
    

}
