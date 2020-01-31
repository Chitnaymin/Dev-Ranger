using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform charater;
    public float distance_offset;
    public float height;
    public float rotation_damping;
    public float height_damping;
    public float zoom_ratio;
    public float defult_fov;

    private float rotation_vector;

    private void FixedUpdate()
    {
        Vector3 local_velocity = charater.InverseTransformDirection(charater.GetComponent<Rigidbody>().velocity);
        if (local_velocity.z < -0.5f)
        {
            //rotation_vector = charater.eulerAngles.y + 100;

        }
        else {

            rotation_vector = charater.eulerAngles.y;
        }
        float accelaration = charater.GetComponent<Rigidbody>().velocity.magnitude;
        Camera.main.fieldOfView = defult_fov + accelaration + zoom_ratio + Time.deltaTime;
        
    }
    private void LateUpdate()
    {
        float wantedAngle = rotation_vector;
        float wantedHeight = charater.position.y + height;
        float myAngle = transform.eulerAngles.y;
        float myHeight = transform.position.y;

        myAngle = Mathf.LerpAngle(myAngle, wantedAngle, rotation_damping * Time.deltaTime);
        myHeight = Mathf.LerpAngle(myHeight,wantedHeight , height_damping * Time.deltaTime);
        Quaternion current_rotattion = Quaternion.Euler(0, myAngle, 0);
        transform.position = charater.position;
        transform.position -= current_rotattion * Vector3.forward * distance_offset;
        Vector3 temp = transform.position;
        temp.y = myHeight;
        transform.position = temp;
        transform.LookAt(charater);
    }

}
