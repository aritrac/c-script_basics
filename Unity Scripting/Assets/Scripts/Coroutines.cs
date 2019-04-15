using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //A normal statement to be printed without delay
        Debug.Log("This is a coroutine demonstration");

        //Method1
        StartCoroutine(executeSomething()); //If we call a coroutine like this, then we cannot stop the execution immediately by using the below signature StopCoroutine("executeSomething");

        //Method2
        StartCoroutine("executeSomething"); //If we call a coroutine like this, then we can stop the execution immediately by using the below signature StopCoroutine("executeSomething")

        //This will stop the execution of the coroutine executeSomething.
        StopCoroutine("executeSomething");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator executeSomething()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Print Something");
    }
}
