using UnityEngine;



internal class GameManager : MonoBehaviour
{
    public int score { get; private set; }


    public void IncrementScore()
    {
        this.score++;
    }
}