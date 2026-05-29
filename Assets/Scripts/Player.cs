using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private Camera _cameraMain;
    void Start()
    {
        speed = 5;
        _cameraMain = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue inputValue) 
    {
        Vector2 move = inputValue.Get<Vector2>(); // Tomamos el valor recibido de la accion.
        _rb.linearVelocity = move * speed;
    }

    void Update()
    {
        Vector2 MouseWorldPoint = _cameraMain.ScreenToWorldPoint(Mouse.current.position.ReadValue()); 
        Vector2 GunPoint = MouseWorldPoint - (Vector2)transform.position;


        Debug.Log("Esta disparando en: "+GunPoint);
    }
}
