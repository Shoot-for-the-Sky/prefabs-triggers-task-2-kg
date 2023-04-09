using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBodyImageSourceScript : MonoBehaviour
{

    [SerializeField] protected List<Sprite> sprites;
    private int maxCarNumber = 6;
    private int spriteIndex;

    // Start is called before the first frame update
    void Start()
    {
        spriteIndex = GetRandomIntInRange(0, maxCarNumber);
        ChangeSprite(spriteIndex);
    }

    private void ChangeSprite(int spriteIndex)
    {
        Debug.Log("Sprites length: " + sprites.Count);
        Debug.Log("Sprite Index is: " + spriteIndex);
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[spriteIndex];
        Debug.Log("Changed car sprite: " + spriteRenderer.sprite);
    }

    // Take help from: https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
    // Give random integer in range of: [min, max)
    private int GetRandomIntInRange(int min, int max)
    {
        System.Random r = new System.Random();
        int randomInt = r.Next(min, max);
        return randomInt;
    }
}
