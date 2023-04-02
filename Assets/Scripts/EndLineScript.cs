using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLineScript : MonoBehaviour
{
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("other tag: " + other.tag);
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("Win Game!!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
