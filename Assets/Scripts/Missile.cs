using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Missile : MonoBehaviour
{
    Rigidbody rb;
    

    [SerializeField]
    private Vector3 direction=Vector3.forward;

    [SerializeField]
    private float speed=10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }
}
