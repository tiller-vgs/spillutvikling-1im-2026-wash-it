using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CarRotation : MonoBehaviour
{
    public List<Texture2D> sprites;
    public InputActionAsset inputActions;
    private InputAction m_Action;
    private Vector2 m_MoveAmt;
    private SpriteRenderer renderer;

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
    }

    // Update is called once per frame
    void Update()
    {
        m_MoveAmt = m_Action.ReadValue<Vector2>();
        if (m_MoveAmt.x > 0)
        {
        }
        else
        {
        }
    }
}
