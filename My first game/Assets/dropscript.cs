using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropscript : MonoBehaviour
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
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
            IownCamera();
        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
            IownCamera();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
            IownCamera();
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Instantiate(bombCloneTemplate, transform.position, transform.rotation);
            IownCamera();
        }
    }
    void IownCamera()
    {
        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 1, -3);
        Camera.main.transform.rotation = transform.rotation;
    }
}
