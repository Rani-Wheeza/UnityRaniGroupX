using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberGuyScript : MonoBehaviour
{

    public GameObject bombCloneTemplate;
    private float rotSpeed = 360;
    private float currentSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
            IownCamera();
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
            IownCamera();
        if (Input.GetKey(KeyCode.S))
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
            IownCamera();
        if (Input.GetKeyUp(KeyCode.B))
            Instantiate(bombCloneTemplate, transform.position, transform.rotation);
            IownCamera();
    }

    void IownCamera()
    {
        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 1, -3);
    }
}
