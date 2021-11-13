using UnityEngine;

public class SiteSelection : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Painted();
        }
    }

    private void Painted()
    {
        Vector2 ray = Input.mousePosition;
        RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(ray));
        if (hit.collider != null)
        {
            if (SelectedMaterial.SelectedColor == Color.white)
            {
                Debug.Log("Выберите цвет");
            }
            else
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().material.color = SelectedMaterial.SelectedColor;
            }
            
        }
        else
        {
            Debug.Log("Выберите квадрат");
        }
        
    }


}
