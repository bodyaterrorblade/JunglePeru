using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uicontroller : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject PauseMenu1;
    public GameObject PauseMenu2;
    public GameObject GamePanel;
    public GameObject GamePanel1;
    public GameObject GamePanel2;
    public GameObject EGPanel;
    //public GameObject pauseMenu;
    public bool isPaused;
    public bool Started;
    Spawn spawnn;
    frut fruit;

    private void Start()
    {
        spawnn = FindObjectOfType<Spawn>();
        fruit = FindObjectOfType<frut>();
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        isPaused = false;
        Time.timeScale = 1;
    }
    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
    
    public void Continue()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
    public void MainMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        isPaused = false;
    }
    private void NewGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(!PauseMenu.activeSelf);
        isPaused = PauseMenu.activeSelf;
        Time.timeScale = 0;
    }
    public void PauseGame1()
    {
        PauseMenu1.SetActive(!PauseMenu1.activeSelf);
        isPaused = PauseMenu1.activeSelf;
        Time.timeScale = 0;
    }
    public void PauseGame2()
    {
        PauseMenu2.SetActive(!PauseMenu2.activeSelf);
        isPaused = PauseMenu2.activeSelf;
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        GamePanel.SetActive(!GamePanel.activeSelf);
        Started = GamePanel.activeSelf;
        Time.timeScale = 1;
        isPaused = false;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
