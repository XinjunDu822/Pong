using Unity.VisualScripting;
using UnityEngine;

public class paddleOneScript : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true && transform.position.y <= 4.1)
        {
            transform.position += (Vector3.up * moveSpeed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) == true && transform.position.y >= -4.1)
        {
            transform.position += (Vector3.down * moveSpeed) * Time.deltaTime;
        }
    }
}
