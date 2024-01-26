using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    AM_LocalPlayerInputs _inputActions;

    private void Awake()
    {
        _inputActions = new AM_LocalPlayerInputs();
        _inputActions.PlayerInput.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = _inputActions.PlayerInput.Move.ReadValue<Vector2>();

        // Debug.Log(inputVector);

        return inputVector;
    }
}
