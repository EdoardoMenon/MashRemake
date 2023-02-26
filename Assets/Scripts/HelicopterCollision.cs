using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCollision : MonoBehaviour
{
    [SerializeField] HelicopterController helicopterController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Tree"))
        {
            //TODO: Show gameover screen
        }
        else if (collision.collider.CompareTag("Person"))
        {
            helicopterController.CollectPerson(collision.collider.gameObject);   
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hospital"))
        {
            helicopterController.UnloadPeople();
        }
    }
}
