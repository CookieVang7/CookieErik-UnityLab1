using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private Transform mainTransform; //The bullet itself
    [SerializeField] private float moveSpeed; //How fast the bullet will move
    [SerializeField] private float moveTime; //How long the bullet moves before its destroyed

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireRoutine());
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if ()
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    IEnumerator FireRoutine()
    {
        float timePassed = 0f;
        while (timePassed <= moveTime)
        {
            timePassed += Time.deltaTime;
            mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }
}
