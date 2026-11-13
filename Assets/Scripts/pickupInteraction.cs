using TMPro;
using UnityEngine;

public class pickupInteraction : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            collision.gameObject.SetActive(false);
            scoreManager.instance.addPoint();
        }
    }


}
