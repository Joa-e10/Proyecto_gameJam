using UnityEngine;

public abstract class Character : MonoBehaviour
{

    [SerializeField] protected int health = 3;
    protected int speed;
    protected Rigidbody2D _rb;

    protected virtual void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        

        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Update()
    {

    }

    protected virtual void Die()
    {
        
        Destroy(gameObject);
    }
}
