using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelTrigger : MonoBehaviour
{

   private void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
        Invoke(nameof(LoadNextLevel), 1f);
       }
   }

   private void LoadNextLevel()
   {
       if (SceneManager.GetActiveScene().buildIndex + 1 == SceneManager.sceneCountInBuildSettings)
       { 
           SceneManager.LoadScene(0);
       }
       else
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       }
   }
}
