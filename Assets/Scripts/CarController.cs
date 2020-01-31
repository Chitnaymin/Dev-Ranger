using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private WheelCollider fl, fr, rl, rr;
    [Space]
    [Range(100,1000)]
    [SerializeField]
    private int speed = 100;
    [SerializeField]
    private Transform steer;
    [SerializeField]
    [Range(10, 100)]
    private int angle = 10;
    private void Start()
    {
            
    }
    private void Update()
    {
        float forward = Input.GetAxis("Vertical");
        rl.motorTorque = 1 * speed;
        rr.motorTorque = 1 * speed;
        fl.steerAngle = -steer.rotation.z * angle;
        fr.steerAngle = -steer.rotation.z * angle;
        //Debug.Log(steer.rotation.z*angle);
        //Debug.Log(EventSystem.);
        

    }
}
