using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesCategorySCR : MonoBehaviour {
    public GameObject[] Circles;
    public GameObject[] Oblong;
    public GameObject[] Rectangle;
    public GameObject[] Square;
    public GameObject[] Triangle;
    public GameObject[] Questions;
    public GameObject[] Stars;
    public GameObject ScoreWindow;
    public GameObject ShapesCategory;
    public GameObject SizesCategory;
    int Score;
    int answer;
    int TotalScore, current;
    int keyLog = 0;
    int number = 0;
    bool Quest1 = false;
    int[] QuestionIndex = { 0, 1, 2, 3, 4 };
    int[] CircleIndex = { 0, 1, 2, 3, 4 };
    int[] OblongIndex = { 0, 1, 2, 3, 4 };
    int[] RectangleIndex = { 0, 1, 2, 3, 4 };
    int[] SquareIndex = { 0, 1, 2, 3, 4 };
    int[] TriangleIndex = { 0, 1, 2, 3, 4 };
    int[] Positions = { -400, -220, 1, 220, 400 };
	void Start () {
      
        
        if (Quest1 == false)
        {
            QuestionIndex = randomPos(QuestionIndex);//questions index
            CircleIndex = randomPos(CircleIndex);
            OblongIndex = randomPos(OblongIndex);
            RectangleIndex = randomPos(RectangleIndex);
            SquareIndex = randomPos(SquareIndex);
            TriangleIndex = randomPos(TriangleIndex);
            Quest1 = true;
        }
       
       //shuffle Choices
       
        Positions = randomPos(Positions);
  
        //add questions
        if (keyLog != 0)
        {
            Questions[QuestionIndex[keyLog - 1]].SetActive(false);
            Circles[CircleIndex[keyLog-1]].SetActive(false);
            Oblong[OblongIndex[keyLog-1]].SetActive(false);
            Rectangle[RectangleIndex[keyLog-1]].SetActive(false);
            Square[SquareIndex[keyLog-1]].SetActive(false);
            Triangle[TriangleIndex[keyLog-1]].SetActive(false);
        }
        Vector3 Quest = Questions[QuestionIndex[keyLog]].transform.position;
        Quest = new Vector3(-40, 230, 0);
        Questions[QuestionIndex[keyLog]].transform.localPosition = Quest;
        Questions[QuestionIndex[keyLog]].SetActive(true);
     
        answer = QuestionIndex[keyLog];
        Vector3 Temp1 = Circles[CircleIndex[keyLog]].transform.position;
            Temp1 = new Vector3(Positions[0], 8, 0);
            Circles[CircleIndex[keyLog]].transform.localPosition = Temp1;
            Circles[CircleIndex[keyLog]].SetActive(true);

            Vector3 Temp2 = Oblong[OblongIndex[keyLog]].transform.position;
            Temp2 = new Vector3(Positions[1], 8, 0);
            Oblong[OblongIndex[keyLog]].transform.localPosition = Temp2;
            Oblong[OblongIndex[keyLog]].SetActive(true);

            Vector3 Temp3 = Rectangle[RectangleIndex[keyLog]].transform.position;
            Temp3 = new Vector3(Positions[2], 8, 0);
            Rectangle[RectangleIndex[keyLog]].transform.localPosition = Temp3;
            Rectangle[RectangleIndex[keyLog]].SetActive(true);

            Vector3 Temp4 = Square[SquareIndex[keyLog]].transform.position;
            Temp4 = new Vector3(Positions[3], 8, 0);
            Square[SquareIndex[keyLog]].transform.localPosition = Temp4;
            Square[SquareIndex[keyLog]].SetActive(true);

            Vector3 Temp5 = Triangle[TriangleIndex[keyLog]].transform.position;
            Temp5 = new Vector3(Positions[4], 8, 0);
            Triangle[TriangleIndex[keyLog]].transform.localPosition = Temp5;
            Triangle[TriangleIndex[keyLog]].SetActive(true);
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


    public void CircleBTNS()
    {
        keyLog++;
        if (answer == 0)
        {
            Score++;
     
        }
        if (keyLog != 5) {
            Start();
        }
   
     

    }
    public void OblongBTNS()
    {
        keyLog++;
        if (answer == 1)
        {
            Score++;
       
        }
        if (keyLog != 5)
        {
            Start();
        }
      
       
     
    }
    public void RectangleBTNS()
    {
        keyLog++;
        if (answer == 2)
        {
            Score++;
    
        }
        if (keyLog != 5)
        {
            Start();
        }
      
      
    }
    public void SquareBTNS()
    {
        keyLog++;
        if (answer == 3)
        {
            Score++;
      
        }
        if (keyLog != 5)
        {
            Start();
        }
    
    }
    public void TriangleBTNS()
    {
        keyLog++;
        if (answer == 4)
        {
            Score++;
        
      
        }
        if (keyLog != 5)
        {
            Start();
        }
      
    
    }
    public void next()
    {
        ShapesCategory.SetActive(false);
        SizesCategory.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
     
        if (keyLog == 5)
        {
            while (number != Score * 2)
            {
                Stars[number].SetActive(true);
                number++;
            }
            ScoreWindow.SetActive(true);
            current = PlayerPrefs.GetInt("TotalScore");
            TotalScore = (Score*2) + current;
            PlayerPrefs.SetInt("TotalScore", TotalScore);
        }
	}
}
