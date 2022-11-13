using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject EnemyToAttack;

    public float speed = 10f;
    public float attackDistance = 1f;

    GameObject Player;

    PlayerAttack pa;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        pa = Player.GetComponent<PlayerAttack>();
    }

    private void Update()
    {
        if(pa.EnemyAttacked != null)
        {
            EnemyToAttack = pa.EnemyAttacked;
        }

        transform.position = Vector3.MoveTowards(transform.position, EnemyToAttack.transform.position, Time.deltaTime * speed);

        float dist = Vector3.Distance(EnemyToAttack.transform.position, transform.position);
        
        if (dist < attackDistance)
        {
            Attack();
        }
    }

    void Attack()
    {
        EnemyToAttack.GetComponent<Enemy>().TakeDamage(10);
    }
}
