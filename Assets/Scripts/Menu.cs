using UnityEngine;
using UnityEngine.SceneManagement;
    
    public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;

	public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.Log("Application Quits");
        Application.Quit();

    }
    public void MainMenuOn()
    {
        mainMenu.SetActive(true);
    }
    public void LevelSelectMenuOn()
    {
        levelMenu.SetActive(true);
    }
}
