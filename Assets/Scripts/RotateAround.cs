using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    

        
        if ((Input.GetKey(KeyCode.A) == true) && (Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
        {
            transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.D) == true) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
        {
            transform.RotateAround(Vector3.zero, Vector3.down, Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.W) == true) && (Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
        {
            transform.RotateAround(Vector3.zero, Vector3.right, Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.S) == true) && (Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.A) == false))
        {
            transform.RotateAround(Vector3.zero, Vector3.left, Time.deltaTime * speed);
        }
    }
}
