using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ammoType;

    public float shotSpeed;
    public float shotCounter, fireRate;

    private Animator playerAnim; //animation

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponentInParent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
            {
                shotCounter = fireRate;
                Shoot();

            }
            //playerAnim.SetBool("Shoot", true); //Animation
        }
        else
        {
            //shotCounter = 0;
            //playerAnim.SetBool("Shoot", false); // Animation
        }
    }
    void Shoot () //instantiate Prefab
    {
        int playerDir()
        {
            if (transform.parent.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }
        GameObject shot = Instantiate(ammoType, firePoint.position, firePoint.rotation);
        Rigidbody2D shotRB = shot.GetComponent<Rigidbody2D>();
        shotRB.AddForce(firePoint.right * shotSpeed * playerDir(), ForceMode2D.Impulse);
        Destroy(shot.gameObject, 1f);
    }
}
