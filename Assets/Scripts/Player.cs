using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField, Range(1, 10), Tooltip("Speed Control")] float speed = 5;

    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

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

        if (Input.GetButton("Fire1"))
        {
            Instantiate(Cube);
        }

        transform.position += direction * speed * Time.deltaTime;
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }
}
