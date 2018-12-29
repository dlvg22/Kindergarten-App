using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternsCategorySCR : MonoBehaviour {
    public GameObject[] Animals;
    public GameObject[] fruits;
    public GameObject[] category;
    public GameObject[] Stars;
    public GameObject[] questions;
    public GameObject PatternsCategory;
    
    public GameObject ScoreWindow;
    int keyLog=0;
    int number=0;
    int score=0;
    int Score=0;
    bool answer = false;
    int[] index = { 0, 1, 2, 3, 4 };
	// Use this for initialization
	void Start () {
        if (keyLog == 0)
        {
            index = randomPos(index);
        }
       
        if (index[keyLog] <= 2)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        questions[index[keyLog]].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (keyLog == 5)
        {
            ScoreWindow.SetActive(true);
        }
        while (number != Score * 2)
        {
            Stars[number].SetActive(true);
            number++;
        }
	}
    public void next()
    {
        PatternsCategory.SetActive(false);
    }
    public void YesBTN()
    {
        questions[index[keyLog]].SetActive(false);
        keyLog++;
        if (answer == true)
        {
            Score++;
    
        }
        if (keyLog != 5)
        {
            Start();
        }
    }
    public void NoBTN()
    {
        questions[index[keyLog]].SetActive(false);
        keyLog++;
        
        if (answer == false)
        {
            Score++;
           
        }
        if (keyLog != 5)
        {
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
