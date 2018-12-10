using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsCategorySCR : MonoBehaviour {

	// Use this for initialization
    public GameObject[] choice;
    public GameObject[] questions;
    public GameObject[] right; 
    int answer;
	void Start () {
        int[] Positions = {62,-49,-159};
        int[] value ={1,2,3,4,5,6,7,8,9};
        int[] key;
        int index = 0;
      value = shuffleChoice(value);
      key = randomPos(Positions);
        for(int a=0; a<3; a++)
        {
            Vector3 Temp = choice[value[a]].transform.localPosition;
            Temp = new Vector3 (227, key[a],0);
            choice[value[a]].SetActive(true);   
            choice[value[a]].transform.localPosition = Temp;
            
            index = value[a];
            Debug.Log(value[a]);
        }
        answer = index;
        Vector3 Quest = questions[index].transform.position;
        Quest = new Vector3(-251, -50, 0);
        Debug.Log(index);
        questions[index].transform.localPosition = Quest;
        questions[index].SetActive(true);
	}
    
    public int[] shuffleChoice(int[] array)

      //shuffle Y position;
    {
        for (int t = 0; t < 8; t++)
        {
            int tmp = array[t];
            int r = Random.Range(0, array.Length-1);
            array[t] = array[r];
            array[r] = tmp;
            // Debug.Log(tmp);
        }

        return array;

    }
   public int[] randomPos(int[] array)

       //shuffle Y position;
    {
        for (int t = 0; t <3; t++)
        {
            int tmp = array[t];
            int r = Random.Range(t, array.Length);
            array[t] = array[r];
            array[r] = tmp;
           // Debug.Log(tmp);
        }
   
        return array;

    }
   public void ChoiceOne()
   {
       if (answer == 0)
       {
           right[0].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       questions[0].SetActive(false);
       Start();
   }
   public void ChoiceTwo()
   {
       if (answer == 1)
       {
           right[1].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[1].SetActive(false);

   }
   public void ChoiceThree()
   {
       if (answer == 2)
       {
           right[2].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }

       Start();
       questions[2].SetActive(false);
   }
   public void ChoiceFour()
   {
       if (answer == 3)
       {
           right[3].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[3].SetActive(false);

   }
   public void ChoiceFive()
   {
       if (answer == 4)
       {
           right[4].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[4].SetActive(false);
   }
   public void ChoiceSix()
   {
       if (answer == 5)
       {
           right[5].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[5].SetActive(false);
   }
   public void ChoiceSeven()
   {
       if (answer == 6)
       {
           right[6].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[6].SetActive(false);
   }
   public void ChoiceEight()
   {
       if (answer == 7)
       {
           right[7].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[7].SetActive(false);
   }
   public void ChoiceNine()
   {
       if (answer == 8)
       {
           right[8].SetActive(true);
       }
       else
       {
           Debug.Log("FUCKIT");
       }
       Start();
       questions[8].SetActive(false);
   }

	
	// Update is called once per frame
	void Update () {
      
	}
}
