using UnityEngine;

public class CheckColider : MonoBehaviour
{
    [SerializeField] private GameObject _box;
    
    private Color _boxMaterial;

    public static bool victory;


    private void Update()
    {
        _boxMaterial = _box.GetComponent<SpriteRenderer>().material.color;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Color collisionColor = collision.gameObject.GetComponent<SpriteRenderer>().material.color;
        
            if (_boxMaterial == Color.white || collisionColor == _boxMaterial || collisionColor == Color.white)
            {
                victory = false;
            }
            else
            {
                victory = true;
            }
    }
}

