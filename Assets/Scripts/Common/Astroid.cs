using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    public float speed = 20;
    public float rotationRate = 20;
    public GameObject explosion;

    Vector3 direction;
    Vector3 rotation;

    Player player;

    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        player.score = player.score + 100;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        direction = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up) * Vector3.forward;
        rotation = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        transform.rotation = transform.rotation * Quaternion.Euler(rotation * rotationRate * Time.deltaTime);
    }
}