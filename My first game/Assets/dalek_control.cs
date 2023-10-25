using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dalek_control : MonoBehaviour
{
    Animator dalekAnimator;
    enum dalekState { Idle, Attack, Follow}
    dalekState currentlyIs = dalekState.Idle;
    // Start is called before the first frame update
    void Start()
    {
        dalekAnimator = GetComponent<Animator>();
        Player = FindAnyObjectByType<Tardis>();
        Player = 
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
                Case dalekState.Attack;
            Break
            if (Vector3.Distance(PlayerPrefs.transform.position, transform))



        if (Input.GetKey(KeyCode.Space))
            dalekAnimator.SetBool("swimming", true);
        else
            dalekAnimator.SetBool("swimming", false);
    }
}
