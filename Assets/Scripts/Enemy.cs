using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemy : Character
{
    protected float detectionRadius = 10;
    private Transform _playerPosition;
    private Player _playerRecived;
    protected NavMeshAgent agent;
    private bool _attacking;
    private Vector2 _directionEnemy;
    private float _distanceToPlayer;
    private int _damageEnemy;
    public Animator animator;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        agent = GetComponent<NavMeshAgent>();
        _playerPosition = GameObject.Find("Player").GetComponent<Transform>();
        _playerRecived = GameObject.Find("Player").GetComponent<Player>();

        agent.updateRotation = false;
        agent.updateUpAxis = false;

        agent.speed = 3;
    }

    public void moveEnemy()
    {
        if (!_attacking)
        {
            _distanceToPlayer = Vector2.Distance(transform.position, _playerPosition.transform.position);

            if (_distanceToPlayer < detectionRadius)
            {
                animator.SetFloat("Vertical", _directionEnemy.y);
                animator.SetFloat("Horizontal", _directionEnemy.x);
                agent.SetDestination(_playerPosition.transform.position);
               _directionEnemy = (agent.steeringTarget - transform.position).normalized;

                Debug.Log("la nueva direccion devuelve: " + _directionEnemy);

            }

        }
    }

    public void attackEnemy() 
    {
        if(_distanceToPlayer <= 2)
        {
            _attacking = true;
            _playerRecived.takesDamage(_damageEnemy);
            
        }
    }
    void Update()
    {
        moveEnemy();
    }
}