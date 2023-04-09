using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class FrogMoverScript : MonoBehaviour
{
    [SerializeField] protected float stepSize = 1f;
    [SerializeField] protected InputAction moveUp = new InputAction(type: InputActionType.Button);
    [SerializeField] protected InputAction moveDown = new InputAction(type: InputActionType.Button);
    [SerializeField] protected InputAction moveRight = new InputAction(type: InputActionType.Button);
    [SerializeField] protected InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField] protected float minXAxisBound = -8f;
    [SerializeField] protected float maxXAxisBound = 8f;
    [SerializeField] protected float minYAxisBound = -3.5f;

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveRight.Enable();
        moveLeft.Enable();
    }

    void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveRight.Disable();
        moveLeft.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if (moveDown.WasPressedThisFrame() && transform.position.y >= minYAxisBound)
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if (moveRight.WasPressedThisFrame() && transform.position.x < maxXAxisBound)
        {
            transform.position += new Vector3(stepSize, 0, 0);
        } else if (moveLeft.WasPressedThisFrame() && transform.position.x > minXAxisBound)
        {
            transform.position += new Vector3(-stepSize, 0, 0);
        }
    }
}
