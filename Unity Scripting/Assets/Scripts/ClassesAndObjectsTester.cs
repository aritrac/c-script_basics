using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesAndObjectsTester : MonoBehaviour
{
    // This is from MonoBehaviour
    void Awake()
    {
        Debug.Log("Called From Awake");
    }
    //This tests out ClassesAndObjects class
    // Start is called before the first frame update
    //void Start()
    //{
    //    ClassesAndObjects warrior = new ClassesAndObjects();
    //    warrior.Info();

    //    ClassesAndObjects newWarrior = new ClassesAndObjects(90,175,"Samum");
    //    newWarrior.Info();
    //}

    //This tests out Inheritance class and is from MonoBehaviour
    void Start()
    {
        //Since Inheritance class inherited from ClassesAndObjects, we now have Info() method in Inheritance class, which we are calling below
        Inheritance inht = new Inheritance();
        inht.Info();
        inht.Attack();
    }

    // Update is called once per frame and is from MonoBehaviour
    void Update()
    {
        
    }

    // From MonoBehaviour
    void FixedUpdate()
    {

    }

    // From MonoBehaviour
    void OnTriggerEnter2D(Collider2D target)
    {

    }

    // From MonoBehaviour
    void OnCollisionEnter2D(Collision2D target)
    {

    }
}
