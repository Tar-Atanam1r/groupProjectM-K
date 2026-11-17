using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString() + " points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " points";
    }
}
