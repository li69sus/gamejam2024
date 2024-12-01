using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Move : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rb;
    public float TimeLeft;
    private bool spedUp;
    public GameObject warning;
    // Start is called before the first frame update
    
    void Start()
    {
        TimeLeft = 33;
        spedUp = false;
    }

    void Update()
    {
        Rb.velocity = transform.up * Speed;
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else if (TimeLeft < 5)
        {
            warning.SetActive(true);
        }
        else if (!spedUp)
        {
            warning.SetActive(false);
            Speed += 2;
            spedUp = true;
        }
    }

}
