using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private float ceiling;
    [SerializeField] private float floor;
    [SerializeField] private Transform paddle;
    [SerializeField] private float moveSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(upKey))
        {
            float currentY = paddle.position.y;
            currentY += moveSpeed * Time.deltaTime;
            currentY = Mathf.Min(currentY, ceiling);

            paddle.position = new Vector3(paddle.position.x, currentY, 0);
        }

        if (Input.GetKey(downKey))
        {
            float currentY = paddle.position.y;
            currentY += -moveSpeed * Time.deltaTime;
            currentY = Mathf.Max(currentY, floor);

            paddle.position = new Vector3(paddle.position.x, currentY, 0);
        }
    }
}
