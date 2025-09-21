using UnityEngine;

public class spawnPongScript : MonoBehaviour
{
    public GameObject pong;
    public logicScript logic;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        spawnPong();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.feedPong)
        {

            Invoke("spawnPong", 1.5f);
            logic.feedPong = false;
        }
    }

    void spawnPong()
    {
        Instantiate(pong, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
