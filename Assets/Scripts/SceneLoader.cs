using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadPvC()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void LoadPvP()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
