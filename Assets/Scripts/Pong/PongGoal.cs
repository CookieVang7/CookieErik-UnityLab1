using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongGoal : MonoBehaviour
{
    public event Action onScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            onScore?.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
