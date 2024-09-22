using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    public float speed = 0;
    public List<Transform> waypoints;
    private int waypontIndex;
    private float range;
    // Start is called before the first frame update
    void Start()
    {
        waypontIndex = 0;
        range = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.LookAt(waypoints[waypontIndex]);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, waypoints[waypontIndex].position) < range)
        {
            waypontIndex++;
            if(waypontIndex >= waypoints.Count)
            {
                waypontIndex = 0;
            }
        }
    }
}
