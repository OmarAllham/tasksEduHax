using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Coin_onclick : MonoBehaviour
{
    public void OnMouseDown() { 
    
    {
            this.GetComponent<SpriteRenderer>().sprite = GoldCoin;

        }

    }

    public  Sprite GoldCoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //   if (Input.GetMouseButton(0))
      //  {
        //    this.GetComponent<SpriteRenderer>().sprite = GoldCoin;

        //}
          
      
    }
}
