using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform gunTransform; //The barrel of the gun
    [SerializeField] private Transform shootPosition; //The place where bullets are instantiated and blasted from
    [SerializeField] private float rotationSpeed; //How fast the gun is spinning

    [SerializeField] private GameObject[] bullets; //A list of bullets that can be instantitated from prefabs

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        gunTransform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadingScreen.LoadScene("MainMenu");
        }
    }

    private void fire()
    {
        GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
    }
}
