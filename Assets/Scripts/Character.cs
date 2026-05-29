using UnityEngine;

public class Characters : MonoBehaviour
{
    private int lives;
    private int speed;
    private Rigidbody2D _rb;

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
