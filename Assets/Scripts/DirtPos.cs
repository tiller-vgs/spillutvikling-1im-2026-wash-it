using UnityEngine;
using UnityEngine.UI;

public class DirtPos : MonoBehaviour
{
    int side = 0;
    public float x = 0;
    public float y = 0;
    public int currentIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        side = Random.Range(1, 5);
        if (side == 1)
        {
            x = Random.Range(-1.5f, 1.5f);
            y = Random.Range(-1.5f, 1.5f);
        }
         else if (side == 2)
        {
            x = Random.Range(-1.5f, 1.5f);
            y = Random.Range(-1.5f, 1.5f);
        }
         else if (side == 3)
        {
            x = Random.Range(-1.5f, 1.5f);
            y = Random.Range(-1.5f, 1.5f);
        }
         else if (side == 4)
        {
            x = Random.Range(-1.5f, 1.5f);
            y = Random.Range(-1.5f, 1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex == 4)
            {
                currentIndex = currentIndex - 3;
            }
            else
            {
                Debug.Log("Right key was pressed");
                currentIndex = currentIndex + 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentIndex == 1)
            {
                currentIndex = currentIndex + 3;
            }
            else
            {
                Debug.Log("Left key was pressed");
                currentIndex = currentIndex - 1;
            }
        }
        if (side == currentIndex)
        {
            GameObject.enabled = true;
        }
            else
            {
                GameObject.enabled = false;
        }
    }
}
