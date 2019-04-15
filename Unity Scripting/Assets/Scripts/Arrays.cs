using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] nums = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = Random.Range(1,100);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log("Element: " + i + " is " + nums[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
