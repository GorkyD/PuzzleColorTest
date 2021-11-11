using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiteSelection : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ScreenMouseRay();
        }
    }

    private void ScreenMouseRay()
    {
        Vector2 ray = Input.mousePosition;
        RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(ray));
        
        if (hit.collider != null)
        {
            if (SelectedMaterial.selectedMaterial == null)
            {
                Debug.Log("Выберите цвет");
            }
            else
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().material = SelectedMaterial.selectedMaterial;
            }
            
        }
        else
        {
            Debug.Log("Выберите квадрат");
        }
        
    }


}
