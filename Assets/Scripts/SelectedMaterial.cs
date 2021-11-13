using UnityEngine;

public class SelectedMaterial : MonoBehaviour
{
    [SerializeField] private Color _red;
    [SerializeField] private Color _blue;
    [SerializeField] private Color _yellow;

    public static Color SelectedColor = Color.white;

    public void SelectRed()
    {
        SelectedColor = _red;
    }
    public void SelectBlue()
    {
        SelectedColor = _blue;
    }
    public void SelectPurple()
    {
        SelectedColor = _yellow;
    }
}
