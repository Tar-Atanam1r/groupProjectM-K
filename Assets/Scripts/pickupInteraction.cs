using UnityEngine;

public class pickupInteraction : MonoBehaviour
{
    private BoxCollider2D cl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cl = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
