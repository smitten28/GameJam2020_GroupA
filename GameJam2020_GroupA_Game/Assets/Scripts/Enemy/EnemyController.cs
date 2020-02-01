﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float enemyHealth;
    [SerializeField] private float enemySpeed;
    [SerializeField] private float stoppingDistance;
    [SerializeField] private bool isRanged;
    [SerializeField] private float cooldown;
    [SerializeField] private GameObject ammo;
    private float timeLeft;
    private GameObject[] targets;
    private GameObject activeTarget;

    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Room");
        timeLeft = 0;
        findTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if(checkDistance() > stoppingDistance)
        {
            follow();
        }
        else if(isRanged)
        {
            fire();
        }

        if(!activeTarget.GetComponent<RoomScript>().isActiveAndEnabled)
        {
            findTarget();
        }
    }

    private void findTarget()
    {
        foreach(GameObject room in targets)
        {
            if(room.GetComponent<RoomScript>().isActiveAndEnabled)
            {
                activeTarget = room;
            }
        }
    }

    private void follow()
    {
        transform.position = Vector2.MoveTowards(transform.position, activeTarget.transform.position, enemySpeed * Time.deltaTime);
    }

    private void fire()
    {
        if(timeLeft <= 0)
        {
            GameObject bullet = Instantiate(ammo, transform.position, Quaternion.identity);
            Vector3 direction = (activeTarget.transform.position - transform.position).normalized;
            bullet.GetComponent<BulletScript>().setDirection(direction);
            timeLeft = cooldown;
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
        
    }

    private float checkDistance()
    {
        return Vector2.Distance(transform.position, activeTarget.transform.position);
    }
}