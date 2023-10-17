using UnityEngine;
using TMPro;


public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    GameManager gameManager;




    private void Start() {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }




    public void UpdateScore()
    {
        this.scoreText.text = gameManager.score.ToString();
    }
}