using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    Rigidbody rb;
    float KickStrength = 80;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void KickBall(Transform kicker)
    {
        rb.AddExplosionForce(KickStrength, kicker.position, 4);
        rb.AddForce(KickStrength * kicker.forward, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("boing!"); }

        else
        {
            dalek_control testIfDalek =
                collision.gameObject.GetComponent<dalek_control>();
            if (testIfDalek != null)
            {
                testIfDalek.dieNOW();
            }
            print("ouch");

            KickBall(collision.transform);
        }
    }
}
