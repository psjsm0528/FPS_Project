using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GunSO gunSO;
    private float coolTime;  // ÃÑ¾Ë ¹ß»ç ÄðÅ¸ÀÓ
    private float shootTime = 0;


    private void Start()
    {
        coolTime = gunSO.coolTime;
    }

    // Update is called once per frame
    void Update()
    {
        HandleFire();

    }

    private void HandleFire()
    {
        if (Input.GetMouseButtonDown(0)
           && shootTime + coolTime <= Time.time)
        {
            Fire();
        }
    }
    private void Fire()
    {    
        shootTime = Time.time;

        //ÃÑ¾Ë »ý¼º
        bullet Instance = Instantiate(bullet, transform.position, Quaternion.identity)
            .GetComponent<bullet>();
        Instance.speed = gunSO.speed;
        Camera cam = Camera.main;
       Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Instance.transform.forward = ray.direction;
    }        
    
}
