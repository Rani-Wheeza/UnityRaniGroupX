using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaecterontrolScript : MonoBehaviour
{




    Vector3 velocity, acceleration;
    float rateOfRotation = 180f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Vector3.zero;


        if (Input.GetKey(KeyCode.F))
        { acceleration = transform.forward; };

        if (Input.GetKey(KeyCode.M))
        { acceleration = -transform.forward;
            IownCamera();
        };

        if ( Input.GetKey(KeyCode.N))
        { transform.Rotate(Vector3.up, rateOfRotation * Time.deltaTime);
            IownCamera();
        };


        if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Rotate(Vector3.forward, rateOfRotation * Time.deltaTime);
            IownCamera();
        };




        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Rotate(Vector3.right, rateOfRotation * Time.deltaTime);
            IownCamera();
        };


        velocity += acceleration * Time.deltaTime;

        // s       =      u        *       t
        transform.position += velocity * Time.deltaTime;
    }


    void IownCamera()
    {
        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 1, -3);
    }
}
