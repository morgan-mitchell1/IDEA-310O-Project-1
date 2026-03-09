using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    public int value = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(value);
            Destroy(gameObject);
        }
    }
}
