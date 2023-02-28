using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletTransform;


    void Start()
    {
        Instantiate(bullet, bulletTransform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
