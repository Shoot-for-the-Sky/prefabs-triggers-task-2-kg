using UnityEngine;

public class FrogRunOverScript : MonoBehaviour
{
    [SerializeField] protected string triggeringTag = "Enemy";
    [SerializeField] protected string frogBodyString = "FrogBody";
    [SerializeField] protected Sprite puddleSprite;
    [SerializeField] protected LogicManager logicManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            SpriteRenderer puddleSpriteComponent = this.transform.Find(frogBodyString).GetComponent<SpriteRenderer>();
            puddleSpriteComponent.sprite = puddleSprite;
            logicManager.GameOver();
        }
    }
}
