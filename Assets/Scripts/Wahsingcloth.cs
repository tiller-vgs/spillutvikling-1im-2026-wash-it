using UnityEngine;

public class SpawnDraggable : MonoBehaviour
{
    public GameObject prefabToSpawn;
    private GameObject currentClone;

    void OnMouseDown()
    {
        // Hvis en kopi finnes → slett den
        if (currentClone != null)
        {
            // Stopp dragging før sletting
            var drag = currentClone.GetComponent<Wahsing_cloth>();
            if (drag != null)
                drag.StopDragging();

            Destroy(currentClone);
            currentClone = null;
            return;
        }

        // Lag ny kopi
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        currentClone = Instantiate(prefabToSpawn, mousePos, Quaternion.identity);

        // Start dragging
        var dragScript = currentClone.GetComponent<Wahsing_cloth>();
        if (dragScript != null)
            dragScript.StartDragging();
    }
}
