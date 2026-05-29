using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected int lives;
    protected int speed;
    protected Rigidbody2D _rb;

    void Start()
    {
        
    }

    public void die() 
    {
        if (lives <= 0) 
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
