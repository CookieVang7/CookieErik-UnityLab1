using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayer : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    [SerializeField] private Transform head;
    [SerializeField] private GameObject[] bullets;
    [SerializeField] private AudioSource shootSound;
    [SerializeField] private FPSUI fpsUI;
    [SerializeField] private int maxHealth;
    
    private int health;
    private int Health
    {
        get { 
            return health; 
        }
        set { 
            health = value;
            //fpsUI.ShowHealthFraction((float)Health / (float)maxHealth);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float lastHitTime;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy") && (Time.time - lastHitTime > 1f))
        {
            lastHitTime = Time.time;
            Destroy(hit.gameObject);
            if (Health > 0)
            {
                Health--;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
            shootSound.Play();
        }
    }
}
