using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject Car;
    [SerializeField] Rigidbody rigid;
    [SerializeField] float maxSpeed, currentSpeed, accelValue, turnSpeed;
    Vector3 moveValue;
    PlayerControls PC;
    bool isAccelerating = false, isTurning = false;
    float turnDirection;
    private void Awake()
    {
        PC = new PlayerControls();
        PC.Player.Enable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //this.transform.position += moveValue * Time.deltaTime * currentSpeed;
        rigid.AddRelativeForce(new Vector3(currentSpeed, 0f, 0f) * Time.deltaTime,ForceMode.Impulse);
        
        if (isAccelerating && currentSpeed < maxSpeed)
        {
            currentSpeed += accelValue;
        }
        else if(currentSpeed > 0)
        {
            currentSpeed -= accelValue;
        }

        if (isTurning)
        {
            this.transform.Rotate(new Vector3(0f,turnDirection*turnSpeed,0f));
        }
    }

    public void OnMove(InputValue input)
    {
        //Try to turn the vehicle left or right
        //store input
        isTurning = true;
        turnDirection = input.Get<Vector2>().x;
        //Decide if vehicle should move left/right
        if (turnDirection == 0)
            isTurning = false;
    }
    public void OnAccelerate(InputValue button)
    {
        if (button.isPressed)
            isAccelerating = true;
        else
            isAccelerating = false;
    }

}
