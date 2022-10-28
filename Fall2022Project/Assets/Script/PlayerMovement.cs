using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject Car;
    [SerializeField] Rigidbody rigid;
    [SerializeField] float maxSpeed, currentSpeed, accelValue;
    Vector3 moveValue;
    PlayerControls PC;
    bool isAccelerating = false;

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
        this.transform.position += new Vector3(currentSpeed,0f,0f) * Time.deltaTime;
        if (isAccelerating && currentSpeed < maxSpeed)
        {
            currentSpeed += accelValue;
        }
        else if(currentSpeed > 0)
        {
            currentSpeed -= accelValue;
        }
    }

    public void OnMove(InputValue input)
    {
        Debug.Log("We tried moving the vehicle.");
        //Add force to the rigidbody in the direction that was pressed.
       Vector2 movement = input.Get<Vector2>();
        moveValue = new Vector3(movement.y, 0f, movement.x);
        this.transform.Rotate(new Vector3(0f,movement.x,0f));
        Debug.Log($"Movement on X axis is {movement.x}");
        Debug.Log($"Movement on Y axis is {movement.y}");
    }
    public void OnAccelerate(InputValue button)
    {
        if (button.isPressed)
            isAccelerating = true;
        else
            isAccelerating = false;
    }
}
