using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCubeControl : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForceAtPosition(Vector3.forward,
               transform.position - 0.5f * Vector3.forward + 0.5f * Vector3.up);

        }

        if (Input.GetKey(KeyCode.Space))   {

            rb.AddExplosionForce(5, transform.position + Vector3.down, 2);  }

    }
}
