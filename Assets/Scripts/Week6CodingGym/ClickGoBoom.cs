using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class ClickGoBoom : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Vector2 mousePos;

    public PirateGoOut pirateGoOut;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pirateGoOut = GetComponent<PirateGoOut>();
    }

    
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
      

        if (Mouse.current.leftButton.isPressed)
        {
            if (spriteRenderer.bounds.Contains(mousePos) == true)
            {
                pirateGoOut.pirategoout();
            }
        }
    }
}
