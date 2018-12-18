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

	// Use this for initialization
	void Start () {
		




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
