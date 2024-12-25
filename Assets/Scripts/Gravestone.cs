using UnityEngine;

public class Gravestone : MonoBehaviour
{
    [SerializeField] private Mesh gravestone;
    [SerializeField] private Mesh destroyedGravestone;

    private bool _isDestroyed;
    private MeshFilter _meshFilter;

    private void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
    }

    public void DestroyGravestone()
    {
        if (_isDestroyed) 
            return;
        
        _isDestroyed = true;
        _meshFilter.mesh = destroyedGravestone;
    }

    public void RestoreGravestone()
    {
        if (!_isDestroyed)
            return;
        
        _isDestroyed = false;
        _meshFilter.mesh = gravestone;
    }

    public bool IsDestroyed()
    {
        return _isDestroyed;
    }
}
