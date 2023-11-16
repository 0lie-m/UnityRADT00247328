using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dalek_control : MonoBehaviour
{
    cubeControl player;
    Animator dalekAnimator;
    enum dalekState { Idle, Attack, Follow, Dying}
    dalekState currentlyIs = dalekState.Idle;
    private float aggroRadius = 100;
    private float walkingSpeed = .8f;
    private float meleeDistance = 1;
    // Start is called before the first frame update
    void Start()
    {
        dalekAnimator = GetComponentInChildren<Animator>();
        player = FindAnyObjectByType<cubeControl>();


    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case dalekState.Idle:
                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = dalekState.Follow;
                    dalekAnimator.SetBool("swimming", true);

                }
                break;

            case dalekState.Attack:



                break;

            case dalekState.Follow:

                transform.LookAt(player.transform.position);
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)

                {
                    currentlyIs = dalekState.Attack;

                }
                break;




            case dalekState.Dying:
                break;

        }

    }

    internal void dieNOW()
    {
        dalekAnimator.SetBool("dead", true);
        Destroy(gameObject, 5);
        currentlyIs = dalekState.Dying;
    }
}