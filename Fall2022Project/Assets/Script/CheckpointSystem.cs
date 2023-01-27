using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour
{
    [SerializeField] int checkpointID;
    BoxCollider[] checkpoints;
    GameObject startCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindCheckpoints()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            if(other.GetComponent<PlayerMovement>().currentCheckpoint == -1 && other.GetComponent<PlayerMovement>().currentLap == -1 && checkpointID == 0)
            {
                other.GetComponent<PlayerMovement>().currentCheckpoint += 1;
                other.GetComponent<PlayerMovement>().currentLap += 1;
            }
            else if(other.GetComponent<PlayerMovement>().currentCheckpoint < checkpointID + 2 && other.GetComponent<PlayerMovement>().currentCheckpoint != 33)
            {
                other.GetComponent<PlayerMovement>().currentCheckpoint += 1;
            }
            else if(other.GetComponent<PlayerMovement>().currentCheckpoint >= 31 && checkpointID == 0)
            {
                other.GetComponent<PlayerMovement>().currentCheckpoint = 0;
                other.GetComponent<PlayerMovement>().currentLap += 1;
            }
            else 
            {
                Debug.Log("Punish player for missing too many checkpoints.");
            }
        }
       if(other.tag == "AI")
        {
            other.GetComponent<RoboMovement>().nextCheckpoint = checkpointID+1;
        }
    }
}
