using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eddcontrollscript : MonoBehaviour
{
    Animator edAnimations;


    // Start is called before the first frame update
    void Start()
    {
        edAnimations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        edAnimations.SetBool("shouldjump", true);
    }
}
