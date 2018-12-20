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
    int keyLog = 0;
    int[] QuestionIndex = { 0, 1, 2, 3, 4 };
    int[] CircleIndex = { 0, 1, 2, 3, 4 };
    int[] OblongIndex = { 0, 1, 2, 3, 4 };
    int[] RectangleIndex = { 0, 1, 2, 3, 4 };
    int[] SquareIndex = { 0, 1, 2, 3, 4 };
    int[] TriangleIndex = { 0, 1, 2 };
    int[] Positions = { -400, -220, 1, 220, 400 };
	void Start () {
        
        QuestionIndex = randomPos(QuestionIndex);//questions index
       //shuffle Choices
        CircleIndex = randomPos(CircleIndex);
        OblongIndex = randomPos(OblongIndex);
        RectangleIndex = randomPos(RectangleIndex);
        SquareIndex = randomPos(SquareIndex);
        TriangleIndex = randomPos(TriangleIndex);
        Positions = randomPos(Positions);
        //add questions
        Vector3 Quest = Questions[QuestionIndex[keyLog]].transform.position;
        Quest = new Vector3(-40, 230, 0);
        Questions[QuestionIndex[keyLog]].transform.localPosition = Quest;
        Questions[QuestionIndex[keyLog]].SetActive(true);
       
            Vector3 Temp1 = Circles[0].transform.position;
            Temp1 = new Vector3(Positions[0], 8, 0);
            Circles[0].transform.localPosition = Temp1;
            Circles[0].SetActive(true);

            Vector3 Temp2 = Oblong[0].transform.position;
            Temp2 = new Vector3(Positions[1], 8, 0);
            Oblong[0].transform.localPosition = Temp2;
            Oblong[0].SetActive(true);

            Vector3 Temp3 = Rectangle[0].transform.position;
            Temp3 = new Vector3(Positions[2], 8, 0);
           Rectangle[0].transform.localPosition = Temp3;
            Rectangle[0].SetActive(true);

            Vector3 Temp4 = Square[0].transform.position;
            Temp4 = new Vector3(Positions[3], 8, 0);
            Square[0].transform.localPosition = Temp4;
            Square[0].SetActive(true);

            Vector3 Temp5 = Triangle[0].transform.position;
            Temp5 = new Vector3(Positions[4], 8, 0);
            Triangle[0].transform.localPosition = Temp5;
            Triangle[0].SetActive(true);



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
	// Update is called once per frame
	void Update () {
		
	}
}
