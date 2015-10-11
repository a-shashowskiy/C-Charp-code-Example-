using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour
{
    public Transform movingPlatform;
    public Transform posUP;
    public Transform posDown;
    public Vector3 newPosition;
    public string curentState;
    public float Smotsh;
    public float resetTime;
     
    // Use this for initialization
    void Start()
    {
        changeTarget();
    }
	
	void FixedUpdate ()
    {
        //Moving platform
        movingPlatform.position = Vector3.Lerp (movingPlatform.position,newPosition,Smotsh*Time.deltaTime);
    }
    //State mashine
    void changeTarget()
    {
        //State change
        if (curentState == "Moving to position 1")
        {
            curentState = "Moving to position 2";
            newPosition = posUP.position;
        }
        else if (curentState=="Moving to position 2")
        {
            curentState = "Moving to position 1";
            newPosition = posDown.position;
        }
        else if (curentState == "")
        {
            curentState = "Moving to position 2";
            newPosition = posUP.position;
        }
        //Reset state to make lift cycle state
        Invoke("changeTarget",resetTime);
    }
  
}
