using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public Transform paintBrushTip;
    public GameObject paintPrefab;

    public GameObject[] colors;

    public List<GameObject> listColors;

    private GameObject _tempPaint;
    private Material _tempMaterial;

    public void StartPainting()
    {
        _tempPaint = Instantiate(paintPrefab, paintBrushTip.position, paintBrushTip.rotation);
        _tempPaint.transform.SetParent(paintBrushTip);

        if (_tempMaterial != null)
        {
            _tempPaint.GetComponent<TrailRenderer>().material = _tempMaterial;
        }
    }

    public void StopPainting()
    {
        if (_tempPaint != null)
        {
            _tempPaint.transform.SetParent(null);
            _tempPaint = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paint"))
        {
            _tempMaterial = other.GetComponent<MeshRenderer>().material;
            paintBrushTip.GetComponent<MeshRenderer>().material = _tempMaterial;
        }
    }
}
