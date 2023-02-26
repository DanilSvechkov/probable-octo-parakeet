using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePress : MonoBehaviour
{
    private SpriteRenderer spriteObj; 

    // Start is called before the first frame update
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>(); 
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed");

            spriteObj.enabled = !spriteObj.enabled; 
        }
        
    }
}
