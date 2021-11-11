using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SelectedMaterial : MonoBehaviour
{
    [SerializeField] private Material _red;
    [SerializeField] private Material _blue;
    [SerializeField] private Material _yellow;

    public static Material selectedMaterial = null;

    public void SelectRed()
    {
        selectedMaterial = _red;
    }
    public void SelectBlue()
    {
        selectedMaterial = _blue;
    }
    public void SelectPurple()
    {
        selectedMaterial = _yellow;
    }
}
