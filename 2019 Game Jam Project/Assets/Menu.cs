using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour { 

    // Update is called once per frame
    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
