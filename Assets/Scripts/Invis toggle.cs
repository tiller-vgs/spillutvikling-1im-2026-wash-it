using UnityEngine;
using UnityEngine.UI;

public class Invistoggle : MonoBehaviour
{
    public Text PlateNum;
    public int Invis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlateNum.enabled = false;
        Invis = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Invis == 1)
            {
                PlateNum.enabled = false;
                Invis = 0;
            }
            else if  (Invis == 0)
            {
                PlateNum.enabled = true;
                Invis = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (Invis == 1)
            {
                PlateNum.enabled = false;
                Invis = 0;
            }
            else if (Invis == 0)
            {
                PlateNum.enabled = true;
                Invis = 1;
            }
        }
    }
}
