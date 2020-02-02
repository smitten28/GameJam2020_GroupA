using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private bool active;
    [SerializeField] private float cooldown;
    private float timeLeft;
    private GameObject room;

    private GameObject[] targets;
    private GameObject activeTarget;

    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        room = transform.parent.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            try
            {
                fire();
            }
            catch
            {
                findTarget();
            }

            if (!room.GetComponent<RoomScript>().returnActiveStatus())
            {
                deactivate();
            }
        }
        else
        {
            if(room.GetComponent<RoomScript>().returnActiveStatus())
            {
                activate();
            }
        }
    }

    private void findTarget()
    {
        foreach(GameObject enemy in targets)
        {
            if(enemy != null)
            {
                activeTarget = enemy;
            }
        }
    }

    private void fire()
    {
        if (timeLeft <= 0)
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

    public void activate()
    {
        active = true;
    }

    public void deactivate()
    {
        active = false;
    }
}
