using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HorrorWarningScreen : MonoBehaviour
{
    public GameObject warningPanel;
    public Button continueButton;
    public Button exitButton;

    void Start()
    {
        Time.timeScale = 0f;

        continueButton.onClick.AddListener(ContinueGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    void ContinueGame()
    {
        Time.timeScale = 1f;
        warningPanel.SetActive(false);
        SceneManager.LoadScene("FirstMission");
    }

    void ExitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}