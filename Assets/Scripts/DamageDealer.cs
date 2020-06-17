using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int  damage = 100;
    [SerializeField] bool destroyOnHit = true;

    public int GetDamage() { return damage; }

    public void Hit()
    {
        Debug.Log("Hit");
        if (destroyOnHit)
        {
            Destroy(gameObject);
        }
        
    }

}
