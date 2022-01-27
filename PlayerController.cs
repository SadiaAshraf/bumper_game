using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public float Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        PlayerRb.AddForce(Vector3.forward * forwardInput * Speed);
    }
}
