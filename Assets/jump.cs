using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 10f; // Сила прыжка героя
    private bool isGrounded = true; // Переменная для определения нахождения героя на земле


    void Update()
    {
        // Проверка нахождения на земле и обработка прыжка
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Добавление силы вверх для прыжка
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpForce);
        isGrounded = false; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // При соприкосновении с землей isGrounded в true
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
