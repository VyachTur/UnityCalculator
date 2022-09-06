using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] _canvases;
    private GameObject _currentCanvasGO;

    private void Start()
    {
        ObjectsDesactivate(_canvases);
    }

    public void ActivateCanvas(GameObject selectableCanvas)
    {
        _currentCanvasGO?.SetActive(false);
        selectableCanvas.SetActive(true);
        _currentCanvasGO = selectableCanvas;
    }

    private void ObjectsDesactivate(GameObject[] objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
