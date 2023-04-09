using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveScript : MonoBehaviour
{

    [SerializeField] protected float minMoveSpeed = 10.0f;
    [SerializeField] protected float maxMoveSpeed = 15.0f;
    [SerializeField] protected float deadZone = -12.0f;
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = GetRandomDoubleInRange(minMoveSpeed, maxMoveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Car deleted");
            Destroy(gameObject);
        }
    }

    // take help from: https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
    private float GetRandomDoubleInRange(float min, float max)
    {
        System.Random r = new System.Random();
        double rDouble = r.NextDouble() * (max - min);
        return (float)(min + rDouble);
    }
}
