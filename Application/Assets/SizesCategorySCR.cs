using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SizesCategorySCR : MonoBehaviour {
    public GameObject[] Small;
    public GameObject[] Medium;
    public GameObject[] Biggest;
    public GameObject[] Stars;
    public GameObject SizesCategory;
    public GameObject SetsCategory;
    public GameObject ScoreWindow;
    int[] Indexes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] myIndex = { -320, 0, 320 };
    int myKey;
    int[] key = { -200, 0, 200 };
    int keyLog = 0;
    int total;
    int FinTotal;
    int number = 0;
	void Start () {
        myKey = 0;
        if (keyLog == 0)
        {
            Indexes = randomPos(Indexes);
        }
        key = randomPos(key);
        if (keyLog != 0)
        {
            Small[Indexes[keyLog-1]].SetActive(false);
            Medium[Indexes[keyLog-1]].SetActive(false);
            Biggest[Indexes[keyLog-1]].SetActive(false);
        }
        Vector3 Temp = Small[Indexes[keyLog]].transform.localPosition;
            Temp = new Vector3(key[0], 100, 0);
            Small[Indexes[keyLog]].SetActive(true);
            Small[Indexes[keyLog]].transform.localPosition = Temp;
          
        Vector3 Temp2 = Medium[Indexes[keyLog]].transform.localPosition;
        Temp2 = new Vector3(key[1], 100, 0);
            Medium[Indexes[keyLog]].SetActive(true);
            Medium[Indexes[keyLog]].transform.localPosition = Temp2;
           
        Vector3 Temp3 = Biggest[Indexes[keyLog]].transform.localPosition;
            Temp3 = new Vector3(key[2], 100, 0);
            Biggest[Indexes[keyLog]].SetActive(true);
            Biggest[Indexes[keyLog]].transform.localPosition = Temp3;
     
       
	}
	
	// Update is called once per frame
	void Update () {
       
        if (keyLog == 10)
        {
            ScoreWindow.SetActive(true);
        
            FinTotal = total / 3;
            Debug.Log(FinTotal);
        }
        while (number != FinTotal)
        {
            Stars[number].SetActive(true);
            number++;
        }
      
	}
    public void next()
    {
        SizesCategory.SetActive(false);
        SetsCategory.SetActive(true);
    }    
    public void SmallBTN()
    {
        Vector3 Sm = Small[Indexes[keyLog]].transform.localPosition;
        Sm = new Vector3(myIndex[myKey], -170, 0);
        Small[Indexes[keyLog]].SetActive(true);
        Small[Indexes[keyLog]].transform.localPosition = Sm;

        if (myKey == 0)
        {
            total++;
        }
        myKey++;
        if (myKey == 3)
        {
            keyLog++;
            Start();
            
        }
    }
    public void MediumBTN()
    {
        Vector3 Temp3 = Medium[Indexes[keyLog]].transform.localPosition;
        Temp3 = new Vector3(myIndex[myKey], -170, 0);
        Medium[Indexes[keyLog]].SetActive(true);
        Medium[Indexes[keyLog]].transform.localPosition = Temp3;

        if (myKey == 1)
        {
            total++;
        }
        myKey++;
        if (myKey == 3)
        {
            keyLog++;
            Start();

        }

    }
    public void BigBTN()
    {
        Vector3 Temp3 = Biggest[Indexes[keyLog]].transform.localPosition;
        Temp3 = new Vector3(myIndex[myKey], -170, 0);
        Biggest[Indexes[keyLog]].SetActive(true);
        Biggest[Indexes[keyLog]].transform.localPosition = Temp3;
    
        if (myKey == 2)
        {
            total++;
        }
        myKey++;
        if (myKey == 3)
        {
            keyLog++;
            Start();
           
        }
    }
    
    public int[] randomPos(int[] array)
    {
        for (int t = 0; t < array.Length; t++)
        {
            int tmp = array[t];
            int r = Random.Range(t, array.Length);
            array[t] = array[r];
            array[r] = tmp;
        }
        return array;
    }


}
