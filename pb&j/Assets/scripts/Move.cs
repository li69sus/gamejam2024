using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = transform.up * Speed;
    }

}
