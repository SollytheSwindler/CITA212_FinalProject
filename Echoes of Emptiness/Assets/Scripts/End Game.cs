using UnityEngine;
using UnityEngine.SceneManagement;
  //Have the player script reference this script to trigger the game over
public class EndGame : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    void EndGameDeathScreen()
    {
        Time.timeScale = 1f;
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }
    
    public void LoadFromLastSave()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}