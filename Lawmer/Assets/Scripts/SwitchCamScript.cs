using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamScript : MonoBehaviour
{
    public Camera cam1;

    public void SwitchCamera()
    {

        cam1.transform.position = new Vector3(11.9f, 23.9f, 5.4f);
        cam1.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        

       
       /* if (cam2.activeSelf)
        {
            cam1.SetActive(true);
        } */
    }
}
