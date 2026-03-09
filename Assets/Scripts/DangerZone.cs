using UnityEngine;
using UnityEngine.SceneManagement;
public class DangerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
        Debug.Log("Player entered danger zone");
        Invoke(nameof(ReStartLevel), 0f);
       }
   }

   private void ReStartLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}