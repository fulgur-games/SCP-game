using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed;

    private Camera cam;
    private ForceMode2D mode;
    private Vector3 direction;
    private Rigidbody2D rb;

    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        mode = ForceMode2D.Impulse;
    }

    private void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        direction = new Vector3(xMove * Time.deltaTime, yMove * Time.deltaTime).normalized;
        rb.AddForce(direction * speed, mode);

        LookAtCursor();
    }

    public void LookAtCursor()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        Vector3 direction = new Vector3(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
        );

        transform.up = -direction;
    }
}
