using UnityEngine;
using System.Collections;

public class Spiner : MonoBehaviour
{
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        //Spin object around one axis
        float tiltAroundY = tiltAngle++;
        Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
