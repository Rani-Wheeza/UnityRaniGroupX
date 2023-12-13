using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Eddcontrollscript : MonoBehaviour
{
    Animator edAnimations;
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        edAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
            edAnimations.SetBool("shouldWalk", true);
            IownCamera();
        }
        else
            edAnimations.SetBool("shouldWalk", false);

        if (Input.GetKey(KeyCode.Space))
        {
            
            edAnimations.SetBool("shouldjump", true);
            IownCamera();
        }
        else 
            edAnimations.SetBool("shouldjump", false);

        if (Input.GetKey(KeyCode.R))
        {
            IownCamera();
            edAnimations.SetBool("shouldrun", true);
        }
        else
            edAnimations.SetBool("shouldrun", false);

        if (Input.GetKey(KeyCode.L))
        {
            IownCamera();
            edAnimations.SetBool("shouldloose", true);
        }
        else
            edAnimations.SetBool("shouldloose", false);

        if (Input.GetKey(KeyCode.T))
        {
            IownCamera();
            edAnimations.SetBool("shouldTPose", true);
        }
        else
            edAnimations.SetBool("shouldTPose", false);


    }

    void IownCamera()
    {
        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 1, -3);
    }
}

