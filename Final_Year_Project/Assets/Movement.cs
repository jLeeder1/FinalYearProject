using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 vec = new Vector3(this.transform.position.x * 0.1f * Time.deltaTime, this.transform.position.y, this.transform.position.z);

            this.transform.position = vec;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 vec = new Vector3(this.transform.position.x * 0.1f * Time.deltaTime * -1, this.transform.position.y, this.transform.position.z);

            this.transform.position = vec;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 vec = new Vector3(this.transform.position.x, this.transform.position.y * 0.1f * Time.deltaTime, this.transform.position.z);

            this.transform.position = vec;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 vec = new Vector3(this.transform.position.x, this.transform.position.y * 0.1f * Time.deltaTime * -1, this.transform.position.z);

            this.transform.position = vec;
        }

        Debug.Log("hello");
    }
}
