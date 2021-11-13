using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject _playMenuUi;
    [SerializeField] private GameObject _levelCompleteMenuUi;

    void Update()
    {
        if (CheckColider.victory)
        {
            _playMenuUi.SetActive(false);
            _levelCompleteMenuUi.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
