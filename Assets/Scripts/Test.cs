using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Vector3 relative;
        relative = transform.InverseTransformDirection(Vector3.forward);
        Debug.Log(relative);
    }
    private void Update()
    {
        Vector3 relative;
        Vector3 original;
        relative = transform.InverseTransformDirection(gameObject.GetComponent<Rigidbody>().velocity);
        original = gameObject.GetComponent<Rigidbody>().velocity;
        Debug.Log(relative + "ori" + original);

        
    }

}
