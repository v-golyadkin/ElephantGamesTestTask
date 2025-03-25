using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MainMenuUI : MonoBehaviour
    {
        public void Level1ButtonClick()
        {
            AudioManager.Instance.PlaySFX("click_ui");

            SceneManager.LoadScene("level_1");

            AudioManager.Instance.ChangeMusic("level_1");
        }

        public void Level2ButtonClick()
        {
            AudioManager.Instance.PlaySFX("click_ui");

            SceneManager.LoadScene("level_2");

            AudioManager.Instance.ChangeMusic("level_2");
        }

        public void ExitButtonClick()
        {
            AudioManager.Instance.PlaySFX("click_ui");

            Application.Quit();
        }
    }
}