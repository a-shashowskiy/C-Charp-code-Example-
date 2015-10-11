using UnityEngine;
using System.Collections;

public class HoldPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        //Make move collided object with platform 
        col.transform.parent=gameObject.transform;
    }
    void OnTriggerExit(Collider col)
    {
        col.transform.parent = null; 
    }
}
