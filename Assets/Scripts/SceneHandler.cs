using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
   public void RestartGame()
    {
        print("de game restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }




}
