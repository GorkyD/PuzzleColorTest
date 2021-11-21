using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _playMenuUi;
    [SerializeField] private GameObject _levelCompleteMenuUi;

    private CheckColider[] _availableColliders = new CheckColider[0];
    private bool victory;


    private void Start()
    {
        _availableColliders = FindObjectsOfType<CheckColider>();
    }


    private void OnEnable()
    {
        foreach (CheckColider collider in _availableColliders)
        {
            collider.OnStateChanged += Box_OnStateChanged;
        }
    }


    private void OnDisable()
    {
        foreach (CheckColider collider in _availableColliders)
        {
            collider.OnStateChanged -= Box_OnStateChanged;
        }
    }

    private void Update()
    {
        if (IsVictory())
        {
            _playMenuUi.SetActive(false);
            _levelCompleteMenuUi.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("Scene_0");
    }


    public void Undo()
    {
        foreach (CheckColider collider in _availableColliders)
        {
            collider.TrySetColor(Color.white);
        }
    }


    private bool IsVictory()
    {
        foreach (CheckColider collider in _availableColliders)
        {
            if (collider.State != BoxState.Completed)
            {
                return false;
            }
        }

        return true;
    }


    private void Box_OnStateChanged(BoxState state)
    {
        
    }
}
