using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseCanvas;

    [SerializeField]
    private GameObject scoreCanvas;

    private void Start() 
    {
        scoreCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    private void Update() 
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            PauseGame();

            pauseCanvas.SetActive(true);
            scoreCanvas.SetActive(false);
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Resume()
    {
        scoreCanvas.SetActive(true);
        pauseCanvas.SetActive(false);

        ResumeGame();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }


    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

}
