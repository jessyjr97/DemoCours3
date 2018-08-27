using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 1;
    [SerializeField] GameObject bulletEmitter;
    // Use this for initialization
    private float timerLastShot = 1;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLastShot += Time.deltaTime;
        var fire1 = Input.GetAxis("Fire1");
        if(fire1 > 0 && timerLastShot > fireRate)
        {
            Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
            timerLastShot = 0;
        }
	}
}
