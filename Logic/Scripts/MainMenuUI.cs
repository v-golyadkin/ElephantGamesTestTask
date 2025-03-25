using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MainMenuUI : MonoBehaviour
    {
        public void Level1ButtonClick()
        {
            SceneManager.LoadScene("level_1");
        }

        public void Level2ButtonClick()
        {
            SceneManager.LoadScene("level_2");
        }

        public void ExitButtonClick()
        {
            Application.Quit();
        }
    }
}