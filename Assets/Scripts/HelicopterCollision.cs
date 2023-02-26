using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Tree"))
        {
            Debug.Log("Hit a tree");
        }
    }
}
