using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    [SerializeField] protected GameObject gameOverScreen;
    [SerializeField] protected GameObject endScreenTitle;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        SetEndScreenTitle("Game Over!");
    }

    public void WinGame() 
    {
        gameOverScreen.SetActive(true);
        SetEndScreenTitle("Win Game!");
    }

    public void SetEndScreenTitle(string newTitle) 
    {
        Warning.Info("SetEndScreenTitle: " + newTitle);
        endScreenTitle.GetComponent<TextMeshProUGUI>().text = newTitle.ToString();
    }
}
