using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    [SerializeField] public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
