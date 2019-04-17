using UnityEngine;

public class Tester : MonoBehaviour
{
    public delegate void Print();
    public static event Print print;

    // Start is called before the first frame update
    void Start()
    {
        //We are trying to find if some method is subscribing to this print event or not. That is what null means in this case
        //If there are no subscribers, then no need to generate the event. We currently have one subscriber in the MyScript class, a method call someFunction() which subscribes to it
        if (print != null)
            print(); //Generating a print event from the Start() method which will be handled by the someFunction() method of the MyScript class
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
