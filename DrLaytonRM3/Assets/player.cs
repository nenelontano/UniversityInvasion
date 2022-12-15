using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Vector3 moveDelta;

    private void Start()       
        {
        boxCollider = GetComponent<BoxCollider2D>();
        }
    private void FixedUpdate()
    {
        //Reset MoveDelta
        moveDelta=Vector3.zero;

        float x = Input.GetAxisRaw("Horizontal");
        
    }
}
