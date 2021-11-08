using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Texture2D mouseTexture;
    public Image pauseIcon;

    private void Update()
    {
        Cursor.SetCursor(mouseTexture, Vector2.zero, CursorMode.Auto);
        transform.position = Input.mousePosition;
    }

    public enum InteractText
    {
        Lire,
        Utiliser,
        Prendre
    };

    public void Pause()
    {
        pauseIcon.enabled = true;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseIcon.enabled = false;
        Time.timeScale = 1;
    }
}
