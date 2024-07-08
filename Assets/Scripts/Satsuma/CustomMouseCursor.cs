using System;
using UnityEngine;


public class CustomMouseCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Texture2D cursorDownTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            Cursor.SetCursor(cursorDownTexture, hotSpot, cursorMode);
        }
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }
}
