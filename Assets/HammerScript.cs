using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x+1, mousePos.y+1);

        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(0,0,90);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.rotation = Quaternion.Euler(0, 0,0);

        }
    }
}
