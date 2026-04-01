using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class CarRotation : MonoBehaviour
{
    public List<Sprite> sprites;
    public InputActionAsset inputActions;
    private InputAction m_Action;
    private Vector2 m_MoveAmt;
    private SpriteRenderer renderer;
    public int currentIndex;
    private int carAmmount;
    private int carColour;

    private void OnEnable()
    {
        inputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        inputActions.FindActionMap("Player").Disable();
    }
    private void Awake()
    {
        var playerMap = inputActions.FindActionMap("Player");
        m_Action = playerMap.FindAction("Move");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>()!;
        carAmmount = sprites.Count / 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex - (carAmmount * carColour) == 4)
            {
                currentIndex = currentIndex - 3;
            }
            else { 
            Debug.Log("Right key was pressed");
            currentIndex = currentIndex + 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentIndex - (carAmmount * carColour) == 1)
            {
                currentIndex = currentIndex + 3;
            }
            else
            {
                Debug.Log("Left key was pressed");
                currentIndex = currentIndex - 1;
            }
        }
        renderer.sprite = sprites[currentIndex];
    }
}
