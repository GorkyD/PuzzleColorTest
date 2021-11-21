using System;
using System.Collections.Generic;
using UnityEngine;

public enum BoxState
{
    Invalid, 
    Filled, 
    Completed
}

public class CheckColider : MonoBehaviour
{
    public event Action<BoxState> OnStateChanged = null;

    [SerializeField] private SpriteRenderer _renderer = null;
    [SerializeField] private List<CheckColider> _neighbours = new List<CheckColider>();

    private BoxState _state = BoxState.Invalid;
    
    public BoxState State
    {
        get => _state;
        private set
        {
            if (_state != value)
            {
                _state = value;
                OnStateChanged?.Invoke(_state);
            }
        }
    }

    private Color Color => _renderer.material.color;
    
    public void TrySetColor(Color color)
    {
        _renderer.material.color = color;

        if (color != Color.white)
        {
            State = BoxState.Filled;

            int validCount = 0;
            foreach (CheckColider neighbour in _neighbours)
            {
                if (neighbour.Color != Color)
                {
                    validCount++;
                }
            }

            if (validCount == _neighbours.Count)
            {
                State = BoxState.Completed;
            }
        }
        else
        {
            State = BoxState.Invalid;
        }
    }
    
#if UNITY_EDITOR
    private void OnValidate()
    {
        if (_renderer == null)
        {
            _renderer = GetComponent<SpriteRenderer>();
        }

        Collider2D collider = GetComponent<Collider2D>();
        List<Collider2D> neighbourColliders = new List<Collider2D>();

        _neighbours.Clear();
        collider.OverlapCollider(new ContactFilter2D(), neighbourColliders);

        foreach (Collider2D neighbourCollider in neighbourColliders)
        {
            CheckColider neighbour = neighbourCollider.GetComponent<CheckColider>();

            if (neighbour != null)
            {
                _neighbours.Add(neighbour);
            }
        }
    }
#endif
}

