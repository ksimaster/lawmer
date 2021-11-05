using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamScript : MonoBehaviour
{
    public Camera cam1;

    public void SwitchCamera_2()
    {

        cam1.transform.position = new Vector3(11.9f, 23.9f, 5.4f);
        cam1.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        

 
    }

    public void SwitchCamera_1()
    {

        cam1.transform.position = new Vector3(0f, 23.1f, 118.1f);
        cam1.transform.rotation = new Quaternion(0f, Mathf.PI, 0f, 0f);



    }
}
