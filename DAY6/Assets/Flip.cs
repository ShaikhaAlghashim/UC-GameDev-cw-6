using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    SpriteRenderer sp;
    bool faceRight = false;
    bool FlipX = false;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
    }
    void flip()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            sp.flipX = false;
            faceRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            sp.flipX = true;
            faceRight = true;
        }
    }
}
