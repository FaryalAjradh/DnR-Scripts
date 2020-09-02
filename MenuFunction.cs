using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunction : MonoBehaviour
{
    public GameObject forestThemeTile, snowThemeTile, fireThemeTile, aboutCanvas, gameCanvas;

    public void OnForestPlayButton()
    {
        GetComponent<AudioSource>().Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Forest");
    }

    public void OnSnowPlayButton()
    {
        GetComponent<AudioSource>().Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Snow");
    }

    public void OnFirePlayButton()
    {
        GetComponent<AudioSource>().Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fire");
    }

    public void OnQuitButton()
    {
        GetComponent<AudioSource>().Play();  
        Application.Quit();
    }

    public void OnThemeButton()
    {
        GetComponent<AudioSource>().Play();  
        UnityEngine.SceneManagement.SceneManager.LoadScene("Themes");
    }   

    public void OnForestChoose()
    {
        GetComponent<AudioSource>().Play();  
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuForest");
    }

    public void OnSnowChoose()
    {
        GetComponent<AudioSource>().Play();  
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuSnow");
    }

    public void OnFireChoose()
    {
        GetComponent<AudioSource>().Play();  
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuFire");
    }

    public void OnButton()
    {
        GetComponent<AudioSource>().Play();  
    }

    public void ShowForestTile()
    {
        forestThemeTile.SetActive(true);
    }

    public void ShowSnowTile()
    {
        snowThemeTile.SetActive(true);
    }

    public void ShowFireTile()
    {
        fireThemeTile.SetActive(true);
    }

    public void HideForestTile()
    {
        forestThemeTile.SetActive(false);
    }

    public void HideSnowTile()
    {
        snowThemeTile.SetActive(false);
    }

    public void HideFireTile()
    {
        fireThemeTile.SetActive(false);
    }

    public void About()
    {
        GetComponent<AudioSource>().Play();  
        aboutCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }

    public void AboutBack()
    {
        GetComponent<AudioSource>().Play();  
        aboutCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }
}
