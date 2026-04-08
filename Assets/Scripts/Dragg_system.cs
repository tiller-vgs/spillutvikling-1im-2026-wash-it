using UnityEngine;

public class Wahsing_cloth : MonoBehaviour
{
    private bool isDragging = false;

    public void StartDragging()
    {
        isDragging = true;
    }

    public void StopDragging()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            transform.position = mousePosition;
        }
    }
}
