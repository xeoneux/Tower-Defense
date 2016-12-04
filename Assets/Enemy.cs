using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        var dir = target.position - transform.position;
        transform.Translate(dir.normalized*speed*Time.deltaTime, Space.World);
    }
}