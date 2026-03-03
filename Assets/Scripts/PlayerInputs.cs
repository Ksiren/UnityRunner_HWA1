using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public bool jump;
    public bool left;
    public bool right;
    public bool down;
    public void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }

    public void OnLeft()
    {

    }

    public void OnRight()
    {

    }

    public void OnDown()
    {
        
    }
}
