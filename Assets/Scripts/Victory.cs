using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject _playMenuUi;
    [SerializeField] private GameObject _levelCompleteMenuUi;
    private bool victory;

    void Update()
    {
        foreach (var box in CheckColider.boxes)
        {
           Debug.Log(box.name + box.GetComponent<Validation>().validation);
        }
        
        if (CheckColider.boxes.All(box => box.GetComponent<Validation>().validation == false) || !CheckColider.boxes.Any())
        {
            victory = false;
        }
        else if (CheckColider.boxes.All(box => box.GetComponent<Validation>().validation))
        {
            victory = true;
        }
        
        if (victory)
        {
            Debug.Log("Победа");
            //_playMenuUi.SetActive(false);
            //_levelCompleteMenuUi.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
