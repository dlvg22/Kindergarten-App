using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsCategorySCR : MonoBehaviour {

	// Use this for initialization
    public GameObject[] choice;
	void Start () {
        int[] Positions = {62,-49,-159};
        int[] key;

      key = randomPos(Positions);
        for(int a=0;a<3; a++)
        {
            Vector3 Temp = choice[a].transform.localPosition;
            Temp.y = key[a];
            choice[a].transform.localPosition = Temp;
            Debug.Log(key[a]);
        }
	}
   public int[] randomPos(int[] array)

       //shuffle Y position;
    {
        for (int t = 0; t < 3; t++)
        {
            int tmp = array[t];
            int r = Random.Range(t, array.Length);
            array[t] = array[r];
            array[r] = tmp;
           // Debug.Log(tmp);
        }
   
        return array;

    }
	
	// Update is called once per frame
	void Update () {
      
	}
}
