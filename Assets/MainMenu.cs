using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;

    public Slider volumeSlider;

    public AudioSource backgroundMusic;
    public AudioSource soundEffects;

    private void Start() // I was a bit lazy and used the same script for all scenes
    {
        float volume = PlayerPrefs.GetFloat("MasterVolume");
        if (backgroundMusic != null && soundEffects != null) // for level scenes
        {
            backgroundMusic.volume = volume;
            soundEffects.volume = volume;
        }
        if (settingsMenu != null) // for main menu scene
        {
            volumeSlider.value = volume;
        }
    }

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
        PlayerPrefs.Save();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
