using System.Collections.Generic;
using UnityEngine;
public class CheckColider : MonoBehaviour
{
    [SerializeField] private GameObject _box;

    public static List<GameObject> boxes;

    private Color _boxMaterial;
    
    private Color _collisionColor;

    private void Start()
    {
        boxes = new List<GameObject>();
    }

    private void Update()
    {
        _boxMaterial = _box.GetComponent<SpriteRenderer>().material.color;
        foreach (var box in boxes)
        {
            _collisionColor = box.GetComponent<SpriteRenderer>().material.color;
            if (_collisionColor == _boxMaterial || _boxMaterial == Color.white || _collisionColor == Color.white)
            { 
                box.GetComponent<Validation>().validation = false;
            }
            else
            { 
                box.GetComponent<Validation>().validation = true;
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        int count = collision.contactCount;
        for (int i = 0; i < count; i++)
        {
            boxes.Add(collision.contacts[i].otherCollider.gameObject);
        }
    }

}

