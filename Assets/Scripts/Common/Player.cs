using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField, Range(1, 10), Tooltip("Speed Control")] float speed = 5;
    [SerializeField, Range(1, 100), Tooltip("Rotate Control")] float rotationRate = 5;

    public GameObject Bullet;
    public Transform bulletOrigin;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.z = Input.GetAxis("Vertical");

        Vector3 rotation = Vector3.zero;
        rotation.y = Input.GetAxis("Horizontal");

        Quaternion rotate = Quaternion.Euler(rotation * rotationRate * Time.deltaTime);
        transform.rotation *= (rotate);
        transform.Translate(direction * speed * Time.deltaTime);
        //transform.position += direction * speed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.A))
        //{
        //    direction.x = -1;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    direction.x = 1;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    direction.z = 1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    direction.z = -1;
        //}

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bullet, bulletOrigin.position, bulletOrigin.rotation);
            Destroy(Bullet, 5);
        }

    }

    private void Awake()
    {
        Debug.Log("Awake");
    }
}
