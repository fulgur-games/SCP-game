using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    public Canvas canvas;
    public Text from, to, obj, content;
    public string fromS, toS, objS, contentS;
    public GameManager gm;

    private void Start()
    {
        canvas.enabled = false;
    }

    private void OnMouseDown()
    {
        canvas.enabled = true;
        gm.Pause();
    }

    private void Update()
    {
        from.text = fromS;
        to.text = toS;
        obj.text = objS;
        content.text = contentS;

        Debug.Log(canvas.enabled);
    }
}
