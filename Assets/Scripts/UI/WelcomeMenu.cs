using UnityEngine;

public class WelcomeMenu : MonoBehaviour
{
    [SerializeField] private GameObject _welcomeMenuUi;
    [SerializeField] private GameObject _playMenuUi;
    [SerializeField] private GameObject _levelCompleteMenuUi;

    public void StartLevel()
    {
        _levelCompleteMenuUi.SetActive(false);
        _welcomeMenuUi.SetActive(false);
        _playMenuUi.SetActive(true);
    }
}
