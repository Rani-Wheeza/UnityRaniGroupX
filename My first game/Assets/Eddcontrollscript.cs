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
        }
        else
            edAnimations.SetBool("shouldWalk", false);

        if (Input.GetKey(KeyCode.Space))
        {
            
            edAnimations.SetBool("shouldjump", true);
        }
        else 
            edAnimations.SetBool("shouldjump", false);

    }
}
