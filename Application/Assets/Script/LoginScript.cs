using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginScript : MonoBehaviour {
    public Text UserField;
	// Use this for initialization
    string user = "Character";
	void Start () {
        if (PlayerPrefs.HasKey(user))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
	}
    public void Character1()    
    {
        PlayerPrefs.SetString(user, "CHRSTNV");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        UserField.text = PlayerPrefs.GetString(user).ToString();
      //  Debug.Log(PlayerPrefs.GetString(user).ToString());  
    }
	
    public void Character2()    
    {
        PlayerPrefs.SetString(user, "CHRSTNV2");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        UserField.text = PlayerPrefs.GetString(user).ToString();
      //  Debug.Log(PlayerPrefs.GetString(user).ToString());  
    }

    public void Character3()    
    {
        PlayerPrefs.SetString(user, "CHRSTNV3");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        UserField.text = PlayerPrefs.GetString(user).ToString();
      //  Debug.Log(PlayerPrefs.GetString(user).ToString());  
    }

    public void Character4()    
    {
        PlayerPrefs.SetString(user, "CHRSTNV4");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        UserField.text = PlayerPrefs.GetString(user).ToString();
      //  Debug.Log(PlayerPrefs.GetString(user).ToString());  
    }

}
