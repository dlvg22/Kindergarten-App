using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSCR : MonoBehaviour {
    public Text Username;
  
    public GameObject[] CharImage;
    string user = "Character";
    public GameObject SettingsMenu;
    string name;
    string result ="";
  
   
    void Start() {
        if (PlayerPrefs.HasKey(result))
        {
           name = PlayerPrefs.GetString(result);
                  // CharImage[1].SetActive(true) ;
          for (int a = 0; a != 4; a++)
            {
                if (name == "Char Image"+ a)
                {
                    CharImage[a].SetActive(true) ;
                    Debug.Log(CharImage[a]);
                    
                }
            }
          //  CharImage[3].SetActive(true);
          //  Debug.Log(name);
        }
   
    }


    void Update()
    {
  
    }
    public static string Player(string key)
    {
        Debug.Log(key);
        return key;
    }

   
 
    public void ChangeChar()
    {
        SceneManager.LoadScene("LoginMenu");
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
