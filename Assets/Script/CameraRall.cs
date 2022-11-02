using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRall : MonoBehaviour
{
    float degreesPerSecond = 40;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, - degreesPerSecond, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-degreesPerSecond, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(degreesPerSecond, 0, 0) * Time.deltaTime);
        }
    }
}
