using UnityEngine;

public class pongMoveScript : MonoBehaviour
{
    public float deadZoneLeft = -9.5f;
    public float deadZoneRight = 9.5f;
    public float pongSpeedHorizontalMax = 14;
    public float pongSpeedHorizontalMin = 10;
    public float pongSpeedVerticalMax = 6;
    public float pongSpeedVerticalMin = 2;
    public float pongSpeedHorizontal;
    public float pongSpeedVertical;
    public AudioSource hitPaddleSound;
    public logicScript logic; 
    int directionX;
    int directionY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       directionY = 0;
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
       hitPaddleSound = GameObject.FindGameObjectWithTag("pongHitSound").GetComponent<AudioSource>();
       directionX = logic.feedToWho();
    }

    // Update is called once per frame
    void Update()
    {
        if (directionX == -1)
            transform.position += (Vector3.left * pongSpeedHorizontal) * Time.deltaTime;
        else
            transform.position += (Vector3.right * pongSpeedHorizontal) * Time.deltaTime;
        if (directionY == -1)
            transform.position += (Vector3.down * pongSpeedVertical) * Time.deltaTime;
        else if (directionY == 1)
            transform.position += (Vector3.up * pongSpeedVertical) * Time.deltaTime;

        if (transform.position.x < deadZoneLeft || transform.position.x > deadZoneRight)
        {
            Destroy(gameObject);
            if (transform.position.x < deadZoneLeft)
                logic.addScore(2);
            else
                logic.addScore(1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            pongSpeedHorizontal = Random.Range(pongSpeedHorizontalMin, pongSpeedHorizontalMax);
            pongSpeedVertical = Random.Range(pongSpeedVerticalMin, pongSpeedVerticalMax);
            hitPaddleSound.Play();
            if (directionY == 0)
                directionY = -1;
            directionX *= -1;
        }
        else if (collision.gameObject.layer == 7)
            directionY *= -1;
    }
}
