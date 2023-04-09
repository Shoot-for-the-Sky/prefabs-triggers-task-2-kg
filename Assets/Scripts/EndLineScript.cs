using UnityEngine;

public class EndLineScript : MonoBehaviour
{
    [SerializeField] protected string triggeringTag;
    [SerializeField] protected LogicManager logicManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("other tag: " + other.tag);
        if (other.tag == triggeringTag && enabled)
        {
            logicManager.WinGame();
        }
    }
}
