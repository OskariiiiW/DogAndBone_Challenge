using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;

    public void LoadScene(string sceneName)
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("sceneName variable missing");
        }

    }

    public void ShowSettingsMenu()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ShowMainMenu()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void VolumeSliderChanged(float volume)
    {
        PlayerPrefs.SetFloat("MasterVolume", volume);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
