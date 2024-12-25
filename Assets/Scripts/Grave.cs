using UnityEngine;

public class Grave : MonoBehaviour
{
    [SerializeField] private Mesh filledGraveMesh;
    [SerializeField] private Mesh unfilledGraveMesh;

    [SerializeField] private bool startAsUnfilled;
    
    private bool _isFilled = true;
    
    private MeshFilter _meshFiler;

    private void Start()
    {
        _meshFiler = this.GetComponent<MeshFilter>();
        
        if (startAsUnfilled)
        {
            _meshFiler.mesh = unfilledGraveMesh;
            _isFilled = false;
        }
    }

    public void FillGrave()
    {
        _isFilled = true;
        _meshFiler.mesh = filledGraveMesh;
    }

    public void DigGrave()
    {
        _isFilled = false;
        _meshFiler.mesh = unfilledGraveMesh;
    }

    public bool IsFilled()
    {
        return _isFilled;
    }
}
