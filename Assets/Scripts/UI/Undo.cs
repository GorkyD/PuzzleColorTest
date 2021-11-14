using UnityEngine;

public class Undo : MonoBehaviour
{
    [SerializeField] private GameObject[] _recordingGameObjects;
    [SerializeField] private Material defaultMaterial;

    public void UndoButton()
    {
        foreach (var gameObject in _recordingGameObjects)
        {
            gameObject.GetComponent<SpriteRenderer>().material = defaultMaterial;
        }
        
    }
}
