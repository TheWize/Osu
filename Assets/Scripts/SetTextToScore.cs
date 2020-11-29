using UnityEngine;
using TMPro;

public class SetTextToScore : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        scoreText.text = GameManager.Score.ToString();
    }
}
