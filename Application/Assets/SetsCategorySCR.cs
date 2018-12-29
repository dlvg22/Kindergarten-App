using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetsCategorySCR : MonoBehaviour {
    int[] values = { 8, 17, 26, 35, 44 };
  
    public GameObject[] Animals;
    public GameObject[] fruits;
    public GameObject[] category;
    public GameObject[] Stars;
    public GameObject[] questions;
    public GameObject SetsCategory;
    public GameObject PatternsCategory;
    public GameObject ScoreWindow;
    int[] Quest = { 0, 1 };
    int[] Position = { 1, 2 };
    int count = 0;
    int number = 0;
    int answer;
    int keyLog = 0;
   string setAnswer;
    int setValue1;
    int setValue2;
    int score = 0;
    int PreValue1;
    int PreValue2;
    int PreObjects1;
    int PreObjects2;
	void Start () {
        bool type = false;
        int[] box = { -370, 130 };
        int boxy1 = 130;
        int boxy2 = 130;
        int[] min = {1,2,3};
        int[] index = { 4, 5, 6, 7, 9 };
        int subTotal1,subTotal2;
        int temp;
        int a = 0;
        int b = 0;
        if (keyLog == 0) 
        {
            values = randomPos(values);
        }
      
        min = randomPos(min);
        box = randomPos(box);
        index = randomPos(index);
        Position = randomPos(Position);
        Quest = randomPos(Quest);
        questions[Quest[0]].SetActive(true);
        subTotal1 = values[keyLog] - min[0];
        subTotal2 = values[keyLog] - min[1];
        temp = values[keyLog] - index[keyLog];
        if (box[0] == -370)
        {
            type = true;

        }
        if (min[0] > min[1] && Quest[0] == 0)
        {
            setAnswer = "set2";
          
        }
        else if (min[0] < min[1] && Quest[0] == 0)
        {
            setAnswer = "set1";
        }
        else if (min[0] > min[1] && Quest[0] == 1)
        {
            setAnswer = "set1";
        }
        else if (min[0] < min[1] && Quest[0] == 1)
        {
            setAnswer = "set2";
        }
        
        //remove previous objects on screen
        if (keyLog != 0)
        {
        
            for (int z = PreValue1; z != PreObjects1 - PreObjects2; z--)
            {

                Animals[z].SetActive(false);
               
            }
            for (int z = PreValue2; z != PreObjects1 - PreObjects2; z--)
            {
                fruits[z].SetActive(false);
            }
        }
        if (type == false && setAnswer =="set2")
        {
            setAnswer = "set1";
        }
        else if(type == false && setAnswer == "set1")
        {
            setAnswer = "set2";
        }

   
        
        for (int z = subTotal1; z != temp; z--)
        {

            Vector3 Temp = Animals[z].transform.localPosition;
            Temp = new Vector3(box[0], boxy1, 0);
            Animals[z].SetActive(true);
            Animals[z].transform.localPosition = Temp;
            box[0] = box[0] - (-100);
           
            a++;
            if (a == 3 || a==6)
            {
                boxy1 = boxy1 - 100;
               
                if (type == true)
                {
                   
                    box[0] = -370;
                }
                else
                {
                    box[0] = 130;
                }
               
            }

        }
     
        for (int x = subTotal2; x != temp; x--)
        {

            Vector3 Temp2 = fruits[x].transform.localPosition;
            Temp2 = new Vector3(box[1], boxy2, 0);
            fruits[x].SetActive(true);
            fruits[x].transform.localPosition = Temp2;
            box[1] = box[1] - (-100);
            b++;
            if (b == 3 || b == 6)
            {
                boxy2 = boxy2 -100;
                if (type == false)
                {
                    box[1] = -370;
                }
                else
                {
                    box[1] = 130;
                }
               
            }

        }
     

        PreValue1 = subTotal1;
        PreValue2 = subTotal2;
        PreObjects1 = values[keyLog];
        PreObjects2 = index[keyLog];
    
        Debug.Log(setAnswer);
	}

    public void set1()
    {
        keyLog++;
        questions[Quest[0]].SetActive(false);
        if (setAnswer == "set1")
        {
            score++;
            
        }
     
        if (keyLog != 5)
        {
            Start();
        }

    }
    public void set2()
    {
        keyLog++;
        questions[Quest[0]].SetActive(false);
        if (setAnswer == "set2")
        {
            score++;
           
        }
      
        if (keyLog != 5)
        {
            Start();
        }
    }
	// Update is called once per frame
	void Update () {
        if (keyLog == 5)
        {
            ScoreWindow.SetActive(true);
        }
        while (number != score*2)
        {
            Stars[number].SetActive(true);
            number++;
        }
	}
    public void next()
    {
        SetsCategory.SetActive(false);
        PatternsCategory.SetActive(true);
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
