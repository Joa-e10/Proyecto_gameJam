using UnityEngine;

public class Stick : MonoBehaviour
{
    private Enemy _enemy;
    
    void Start()
    {
        _enemy = GameObject.Find("Enemy").GetComponent<Enemy>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Player _player = other.gameObject.GetComponent<Player>();

        if (_player != null)
        {
            _enemy.attackEnemy();
        }
    }
    void Update()
    {
        
    }
}
