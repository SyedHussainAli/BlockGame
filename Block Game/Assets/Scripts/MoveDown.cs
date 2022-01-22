using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (transform.position.y<-1)
        {
            Destroy(gameObject);
        }

    }
}
