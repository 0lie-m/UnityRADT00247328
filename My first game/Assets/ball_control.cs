using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    Rigidbody rb;
    float KickStrength = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void KickBall(Transform kicker)
    {
        rb.AddForce(KickStrength * kicker.forward, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("boing!"); }

        else
        {
            print("ouch");

            KickBall(collision.transform);
        }
    }
}
