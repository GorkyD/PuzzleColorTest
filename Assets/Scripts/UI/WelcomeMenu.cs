using UnityEngine;

public class WelcomeMenu : MonoBehaviour
{
    [SerializeField] private GameObject _welcomeMenuUi;
    [SerializeField] private GameObject _playMenuUi;

    public void StartLevel()
    {
        _welcomeMenuUi.SetActive(false);
        _playMenuUi.SetActive(true);
    }
}
