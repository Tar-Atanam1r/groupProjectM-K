using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.Timeline;

public class pickupInteraction : MonoBehaviour
{
    IEnumerator respawn(Collider2D collider)
    {
        yield return new WaitForSeconds(3);
        List<Collider2D> results = new List<Collider2D>();
        var position = new Vector2(Random.Range(-8.5f, 8.5f), Random.Range(-3.5f, 4.65f));

        bool resolved = false;
        while (!resolved)
        {
            position = new Vector2(Random.Range(-8.5f, 8.5f), Random.Range(-3.5f, 4.65f));

            collider.transform.localPosition = position;
            resolved = false;
            results.Clear();

            collider.gameObject.SetActive(true);
            Collider2D c = Physics2D.OverlapBox(position, collider.bounds.size, 0.0f);
            if (c != null)
            {
                resolved = true;
                {
                    if (c.CompareTag("tile"))
                    {
                        resolved = false;
                    }
                }
            }
            else
            {
                resolved = true;
            }
        }

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