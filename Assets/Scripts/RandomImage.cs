using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class RandomImage : MonoBehaviour
{
    public Sprite[] sprites;

    void Start()
    {
        GetComponent<Image>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

    void changeImage()
    {
        
    }
}