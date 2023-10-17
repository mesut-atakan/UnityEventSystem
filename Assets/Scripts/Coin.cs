using UnityEngine;
using UnityEngine.Events;


public class Coin : MonoBehaviour
{
    public UnityEvent coinCollect;


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            this.coinCollect.Invoke();
            Destroy(gameObject);
        }
    }




    public void TestMethod()
    {
        print("Fire Coin Collect");
    }
}