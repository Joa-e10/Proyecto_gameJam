using UnityEngine;

public class Enemy : Character
{
    protected override void Update()
    {
        base.Update(); 
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Recibiciste daño");
            TakeDamage(1);
        }

    }

    protected override void Die()
    {
        Debug.Log("Te quedaste sin vidas y perdiste");
        base.Die(); 
    }
}
