using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void ChangeLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void ChangeLevel(int levelNum)
    {
        SceneManager.LoadScene(levelNum);
    }

    public void toStart()
    {
        SceneManager.LoadScene("Inicialmenu");
    }
}
