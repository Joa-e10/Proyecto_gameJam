using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    private Camera _cameraMain;
    [SerializeField] private GameObject _bulletPlayer;
    private Transform _positionGun;
    private Vector2 _gunPoint;
    private float _shootEnabled;
    void Start()
    {
        speed = 5;
        _cameraMain = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
        _positionGun = GameObject.Find("GunPlayer").GetComponent<Transform>();
    }

    private void OnMove(InputValue inputValue) 
    {
        Vector2 move = inputValue.Get<Vector2>(); // Tomamos el valor recibido de la accion.
        _rb.linearVelocity = move * speed;
    }

    private void OnAttack(InputValue inputValue) 
    {
        GameObject generatedBullet = Instantiate(_bulletPlayer, _positionGun.position, Quaternion.identity);
        Bullet bulletComponent = generatedBullet.GetComponent<Bullet>();
        bulletComponent.setDirectionBullet(_gunPoint);
    }

    void Update()
    {
        Vector2 MouseWorldPoint = _cameraMain.ScreenToWorldPoint(Mouse.current.position.ReadValue()); 
        _gunPoint = MouseWorldPoint - (Vector2)transform.position;


        Debug.Log("Esta disparando en: "+_gunPoint);
    }
}
