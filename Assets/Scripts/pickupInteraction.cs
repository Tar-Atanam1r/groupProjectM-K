using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.Timeline;

public class pickupInteraction : MonoBehaviour
{
    IEnumerator respawn(Collider2D collider)
    {
        yield return new WaitForSeconds(3);
        var position = new Vector2(Random.Range(-8.5f, 8.5f), Random.Range(-3.5f, 4.65f));
        collider.transform.localPosition = position;
        collider.gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            collision.gameObject.SetActive(false);
            scoreManager.instance.addPoint();
            StartCoroutine(respawn(collision));

        }
    }
}