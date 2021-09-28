using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEntchen : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D myRigidbody;

    public bool isWalking;

    public float walkTime;
    public float walkCounter;
    public float waitTime;
    public float waitCounter;

    private int walkDirection;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        waitCounter = waitTime;
        walkCounter = walkTime; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;
            print("Random pick");
           
            switch (walkDirection)
            {
                case 0:
                    myRigidbody.velocity = new Vector2(0, moveSpeed);
                    break;
                case 1:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    break;
                case 2:
                    myRigidbody.velocity = new Vector2(0, -moveSpeed);
                    break;
                case 3:
                    myRigidbody.velocity = new Vector2(-moveSpeed, 0);
                    break;
            }
            if (walkCounter <= 0)
            {
                isWalking = false;
                waitCounter = waitTime;
                print("waiting");
            }
        }
        else
        {
           waitCounter -= Time.deltaTime;

            myRigidbody.velocity = Vector2.zero;

            if(waitCounter <= 0)
            {
                chooseDirection();
            }
        }
    }   
    public void chooseDirection()
    {
        walkDirection = Random.Range(0, 8);
        isWalking = true;
        walkCounter = walkTime;
        print("Walking");
    }
}