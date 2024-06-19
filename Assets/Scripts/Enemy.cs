using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealt;

    private Transform tr;

    void Start()
    {
        currentHealt = maxHealth;
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        if (GetComponent<BoxCollider2D>().isActiveAndEnabled == false)
        {
        UnityEngine.Vector3 newPosition = tr.position;
        newPosition.y = 1f;
        tr.position = newPosition;
        }

    }

    public void IamHurt(int damage)
    {
        currentHealt -= damage;

        // play hurt animation

        if(currentHealt <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        Debug.Log(this.name + " is dead");
        // play dying animation
        // disable enemy
        GetComponent<BoxCollider2D>().enabled = false;
    }


}
