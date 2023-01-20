using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoboMovement : MonoBehaviour
{
    //Placeholder system until I figure out how to spawn in proper racers
    [SerializeField] GameObject checkpointParent;

    //Use this system once you've got it figured out goober
    //GameObject checkpointParent;

    GameObject[] checkpoints;

    //Bunch of code copied over from player movement
    [SerializeField] GameObject Car;
    [SerializeField] Rigidbody rigid;
    [SerializeField] float maxSpeed, currentSpeed, accelValue, turnSpeed;
    NavMeshAgent agent;
    Vector3 moveValue;
    bool isAccelerating = false, isTurning = false, isBraking = false, isBoosting = false;


    //New AI code that's needed
    int difficulty = 0;
    int nextCheckpoint = 1;

    // Start is called before the first frame update
    void Start()
    {
        /* Load in checkpoints somehow
         * load which character
         * Check difficulty of racer?  (Talk to others about this in meeting)
         * 
         * 
         */
        agent = this.GetComponent<NavMeshAgent>();
        FindCheckpoints();
        SetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * See which checkpoint we are on (use basic index to keep track maybe?)
         * Path to current checkpoint
         * Once at checkpoint, increase counter by 1
         * repeat ad infinitum?
        */
        if(this.transform.forward == checkpoints[nextCheckpoint].transform.forward && this.transform.right == checkpoints[nextCheckpoint].transform.right)
        {

        }

        MoveToCheckpoint();
    }

    void FindCheckpoints()
    {
        checkpoints = checkpointParent.GetComponentsInChildren<GameObject>();
    }
    void SetDifficulty()
    {
        switch (difficulty)
        {
            default:
                maxSpeed = 0;
                accelValue = 0;
                turnSpeed = 0;
                break;
        }
    }

    void MoveToCheckpoint()
    {
       // agent.Move(checkpoints[nextCheckpoint + 1])
    }
}
