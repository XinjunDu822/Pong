using UnityEngine;

public class paddleTwoScript : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true && transform.position.y <= 4.1)
        {
            transform.position += (Vector3.up * moveSpeed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true && transform.position.y >= -4.1)
        {
            transform.position += (Vector3.down * moveSpeed) * Time.deltaTime;
        }
    }
}
