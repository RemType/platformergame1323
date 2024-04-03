using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed;
    public float DirectionX, DirectionY;
    Rigidbody2D rb;
    SpriteRenderer rb2;
    void Update()
    {
        MoveAndJump();

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<SpriteRenderer>();
    }
    void MoveAndJump()
    {
        DirectionX = Input.GetAxis("Horizontal");
        DirectionY = Input.GetAxis("Vertical");

        Vector2 movment = new Vector2(DirectionX, DirectionY);
        transform.Translate(movment * Speed * Time.deltaTime);

        if (DirectionX > 0)
        {
            rb2.flipX = false;
        }

        if (DirectionX < 0)
        {
            rb2.flipX = true;
        }
    }
}


