using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jump : MonoBehaviour
{
    public float JumpPower = 300.0f;
    [SerializeField] private LayerMask platformLayerMask;
    BoxCollider2D boxCollider2D;

    private void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded();
        //if (Input.GetKeyDown(KeyCode.Space))
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("space");
            if(IsGrounded())
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpPower));
            }
        }
    }

    public bool IsGrounded()
    {
        float extraHegiht = .1f;
        RaycastHit2D raycastHit = Physics2D.Raycast(
            boxCollider2D.bounds.center,
            Vector2.down,
            boxCollider2D.bounds.extents.y + extraHegiht,
            platformLayerMask);
        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(boxCollider2D.bounds.center, Vector2.down * (boxCollider2D.bounds.extents.y + extraHegiht), rayColor);
        //Debug.Log(raycastHit.collider);

        if(raycastHit.collider != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
