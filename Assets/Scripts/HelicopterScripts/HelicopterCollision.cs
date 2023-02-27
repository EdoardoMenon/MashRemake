using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCollision : MonoBehaviour
{
    [SerializeField] private HelicopterController helicopterController;
    [SerializeField] private AudioSource crashAudioSrc;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Tree"))
        {
            //TODO: Show gameover screen
            crashAudioSrc.Play();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hospital"))
        {
            helicopterController.UnloadPeople();
        }
        if (collision.gameObject.CompareTag("Person"))
        {
            helicopterController.CollectPerson(collision.gameObject);
        }
    }
}
