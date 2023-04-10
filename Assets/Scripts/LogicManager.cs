using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    [SerializeField] protected GameObject gameOverScreen;
    [SerializeField] protected GameObject endScreenTitle;
    [SerializeField] protected FrogMoverScript frogMoverScript;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        frogMoverScript.disabled = true;
        gameOverScreen.SetActive(true);
        SetEndScreenTitle("Game Over!");
    }

    public void WinGame()
    {
        frogMoverScript.disabled = true;
        gameOverScreen.SetActive(true);
        SetEndScreenTitle("Win Game!");
    }

    public void SetEndScreenTitle(string newTitle) 
    {
        endScreenTitle.GetComponent<TextMeshProUGUI>().text = newTitle.ToString();
    }
}
