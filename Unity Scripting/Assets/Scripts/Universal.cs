using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universal : MonoBehaviour
{
    // This Universal class shows how we can access the individual components of a GameObject called Universal
    // Accessing the Animator component of the Universal game object
    Animator anim;

    // Accessing the Rigidbody2D component of the Universal game object
    Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //Getting the actual reference of Animator and RigidBody2D component and assigning them to the references created above
        anim = GetComponent<Animator>();

        myRigidBody = GetComponent<Rigidbody2D>();

        //Getting the actual reference of the Universal script
        Universal script = GetComponent<Universal>();

        //Using the transform reference in the Universal game object
        //The transform component does not need a new reference variable to store its reference
        //unlike the other components discussed above. We can directly use the transform name to access the Transform component of the GameObject like so
        //transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
