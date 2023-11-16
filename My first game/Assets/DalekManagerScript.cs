using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DalekManagerScript : MonoBehaviour
{
    public Transform dalekControlTemplate;
        int numberOfDaleks = 30;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfDaleks; i++)
        {
            Vector3 position = new Vector3(
                 Random.Range(-80f, 80f),
                 5f,
                 Random.Range(-80f, 80f));

            Instantiate(dalekControlTemplate, position, Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
