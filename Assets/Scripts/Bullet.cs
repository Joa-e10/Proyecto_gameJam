using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _damage = 1;
    private float _timeBullet = 1.5f;
    private int _speed = 3;
    private Rigidbody2D _rb;
    private Vector2 _directionBullet;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public void setDirectionBullet(Vector2 direction)
    {
        _directionBullet = direction;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy gosth = other.gameObject.GetComponent<Enemy>();

        if (gosth != null)
        {
            gosth.takesDamage(_damage); 
        }
    }

    void Update()
    {
        _rb.linearVelocity = _directionBullet * _speed;
        _timeBullet -= Time.deltaTime;

        if (_timeBullet <= 0)
        {
            Destroy(gameObject);
            _timeBullet = 1.5f;
        }
        else {

            Debug.Log("Esta navegando la bala");
        }
    }
}
