using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Camera camera;

    public float maxRange = 30f;

    public GameObject EnemyAttacked;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Attacked();
        }
        
    }

    void Attacked()
    {
        RaycastHit hit;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, maxRange))
        {
            if (hit.transform.gameObject.tag == "Enemy")
            {
                EnemyAttacked = hit.transform.gameObject;
                Debug.Log("attacking");
            }
        }
    }
}
