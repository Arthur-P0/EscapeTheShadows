using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPhysics : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(target.transform.position);
    }
}
