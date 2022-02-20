using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ball;
    [SerializeField] private float startSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void restart()
    {
        ball.freezeRotation = true;
        ball.SetRotation(0);
        ball.position = new Vector2(0,1);
        ball.velocity = Vector2.zero;

        StartCoroutine(moveBall());
    }

    IEnumerator moveBall()
    {
        yield return new WaitForSeconds(1);
        Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
        ball.velocity = newVelocity.normalized * startSpeed;
        ball.freezeRotation = false;
    }
}
