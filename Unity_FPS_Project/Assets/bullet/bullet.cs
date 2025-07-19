using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    [SerializeField] public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Fire(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Fire(transform.forward);
    }

    private void Fire(Vector3 movedir)
    {
        transform.position += movedir.normalized* speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Debug.Log(other.name);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
