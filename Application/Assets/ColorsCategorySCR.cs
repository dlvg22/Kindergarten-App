using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ColorsCategorySCR : MonoBehaviour {

	// Use this for initialization
    public int timeLeft = 20; //Seconds Overall
    public Text countdown; //UI Text Object
    public GameObject[] choice;
    public GameObject[] questions;
    public GameObject[] right;
    int[] FinalValue=new int[9];
    public GameObject ColorsCategory;
    public GameObject ShapesCategory;
    int answer;
    int keyLog = 0;
    int[] questionsIndex;
    bool TimerLimit = false;
    bool loop = false;
    int[] PreChoice = new int[3];
 	void Start () {

        
        int[] Positions = {62,-49,-159};
        int[] value ={0,1,2,3,4,5,6,7,8};
        int[] value2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] ChoicesKey = new int[9];
        int[] Choices = new int[9];
        int[] test = new int[9];
       List<int> FinChoice = new List<int>();
       List<int> ConvertChoice;
       int[] Var = new int[9];
        int[] key;
        int[] FINAL;
    
        int a = 0;
  
    
        if (loop!=true)
        {
          FinalValue = randomPos(value);   // for choices to shuffle
          loop = true;
        }
        Choices = randomPos(value2); //for position to shuffle
        key = randomPos(Positions); // for choices position
        FinChoice.Add(FinalValue[keyLog]); // add right answer
        //Convert to string to remove right answer
        ConvertChoice = new List<int>(Choices);
        ConvertChoice.Remove(FinalValue[keyLog]);
        ChoicesKey = ConvertChoice.ToArray();
             while(a != 2){
              FinChoice.Add(ChoicesKey[a]);
              a++;
             }
       
             FINAL = FinChoice.ToArray();

               //remove previous Choices
             if (keyLog != 0)
             {
                 
          
                   questions[FinalValue[keyLog-1]].SetActive(false);
                 for (int y = 0; y != 3; y++)
                 {
                     for (int x = 0; x != 3; x++)
                     {
                         if (FINAL[y] != PreChoice[x])
                         {
                             choice[PreChoice[x]].SetActive(false);
                         }
                     }

                 }

             }
             
             for (int z = 0; z != 3; z++)
             {
                 Vector3 Temp = choice[FinChoice[z]].transform.localPosition;
                 Temp = new Vector3(227, key[z], 0);
                 choice[FinChoice[z]].SetActive(true);
                 choice[FinChoice[z]].transform.localPosition = Temp;
             }
          Vector3 Quest = questions[FinalValue[keyLog]].transform.position;
          Quest = new Vector3(-251, -50, 0);
          questions[FinalValue[keyLog]].transform.localPosition = Quest;
          questions[FinalValue[keyLog]].SetActive(true);
          answer = FinalValue[keyLog];
          PreChoice = FINAL;
      
	}

    IEnumerator PicDelay()
    {
        yield return new WaitForSeconds(1);
        Start();
    }
  
  IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
            
    }
  
    void Update()
    {
      
      countdown.text = ("" + timeLeft);
        if (timeLeft <= 10)
        {
            countdown.color = Color.red;       
        }
        if (timeLeft < 0)
        {
            ColorsCategory.SetActive(false);
            ShapesCategory.SetActive(true);
          //  Debug.Log("Done");
           

        }
        if (keyLog == 9)
        {
            ColorsCategory.SetActive(false);
            ShapesCategory.SetActive(true);
            Debug.Log("Done");
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
   public void ChoiceOne()
   {
     
       if (answer == 0)
       {
           right[0].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
    
       keyLog++;
       
    
      



   }
   public void ChoiceTwo()
   {
       if (answer == 1)
       {
           right[1].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
       keyLog++;
      
       
      
   }
   public void ChoiceThree()
   {
       if (answer == 2)
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
       keyLog++;
      

    
   }
   public void ChoiceFour()
   {
       if (answer == 3)
       {
           right[3].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
       keyLog++;
  
   }
   public void ChoiceFive()
   {
       if (answer == 4)
       {
           right[4].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
   
       keyLog++;
   

     
   }
   public void ChoiceSix()
   {
       if (answer == 5)
       {
           right[5].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
    
       keyLog++;
     
     

     
 
   
 
   }
   public void ChoiceSeven()
   {
       if (answer == 6)
       {
           right[6].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    

       keyLog++;
     
   }
   public void ChoiceEight()
   {
       if (answer == 7)
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
      
    
       keyLog++;
      
   }
   public void ChoiceNine()
   {
       if (answer == 8)
       {
           right[8].SetActive(true);
       }
       else
       {
           right[FinalValue[keyLog]].SetActive(true);
       }
       StartCoroutine("PicDelay");
       if (TimerLimit == false)
       {
           StartCoroutine("LoseTime");
           TimerLimit = true;
       }
    
       keyLog++;
   }
}
