using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ReturnButton : MonoBehaviour
    {
        public void ReturnToMainMenyButtonClick()
        {
            AudioManager.Instance.PlaySFX("click_ui");

            SceneManager.LoadScene("main_menu");

            AudioManager.Instance.ChangeMusic("main_menu");
        }
    }
}