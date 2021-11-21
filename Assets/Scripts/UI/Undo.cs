using UnityEngine;

public class Undo : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    public void UndoButton()
    {
        _gameController.Undo();
    }


#if UNITY_EDITOR
    private void OnValidate()
    {
        if (_gameController == null)
            _gameController = FindObjectOfType<GameController>();
    }
#endif
}
