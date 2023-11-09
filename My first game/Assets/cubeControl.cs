using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    public Transform footballCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKey(KeyCode.W)) 
        transform.position += transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 1000 * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down, 1000 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform newBall = Instantiate(footballCloneTemplate, transform.position + 2* transform.forward,
                Quaternion.identity);
            ball_control myNewBallScript =
            newBall.GetComponent<ball_control>();

            myNewBallScript.KickBall(transform);
        }
    }

}
