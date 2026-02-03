using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MoveToMouseOnClick : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        //was mouse pressed this frame and isnt over ui
        if (Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            //yes: move thing to mouse position
            transform.position = mousePos;
            transform.localScale += Vector3.one;
        }
    }
}
