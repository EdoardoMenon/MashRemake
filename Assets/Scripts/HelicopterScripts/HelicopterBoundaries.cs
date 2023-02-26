using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterBoundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float helicopterHeight;
    private float helicopterWidth;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        helicopterWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        helicopterHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + helicopterWidth, screenBounds.x - helicopterWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + helicopterHeight, screenBounds.y - helicopterHeight);
        transform.position = viewPos;
    }
}
