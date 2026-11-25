using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("FirstMission");
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("FirstMission");
    }

    public void Settings()
    {
        Debug.Log("Открыты настройки");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}