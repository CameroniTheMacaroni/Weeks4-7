using UnityEngine;
using UnityEngine.InputSystem;

public class UIDemo1 : MonoBehaviour
{
    SpriteRenderer sprtRend;
    public float scale = 2f;
    void Start()
    {
        sprtRend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            changecolor();
        }
    }

    public void changecolor()
    {
        sprtRend.color = Random.ColorHSV();
    }

    public void buttonthing()
    {
        transform.localScale = Vector3.one * scale;
        scale = scale * 2;
    }
}
