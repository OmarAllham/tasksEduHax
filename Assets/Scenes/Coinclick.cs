using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinclick : MonoBehaviour
{
    public Sprite GoldCoin;
    public AudioSource Audio;
    public void OnMouseDown()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite != GoldCoin)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = GoldCoin;
            Audio.Play();
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
