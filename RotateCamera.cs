using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speedrotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.up, HorizontalInput* speedrotation * Time.deltaTime);
    }
}
