using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class FrogMoverScript : MonoBehaviour
{
    [SerializeField] float stepSize = 1f;
    [SerializeField] InputAction moveUp = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction moveDown = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction moveRight = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction moveLeft = new InputAction(type: InputActionType.Button);

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if (moveDown.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if (moveRight.WasPressedThisFrame())
        {
            transform.position += new Vector3(stepSize, 0, 0);
        } else if (moveLeft.WasPressedThisFrame())
        {
            transform.position += new Vector3(-stepSize, 0, 0);
        }
    }
}
