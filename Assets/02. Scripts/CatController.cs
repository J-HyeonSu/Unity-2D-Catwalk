using System;
using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRb;
    private Animator catAnim;
    
    public float jumpPower = 10f;
    public bool isGround = false;
    
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            catAnim.SetTrigger("Jump");
            
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++; // 1씩 증가
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("isGround", false);
            isGround = false;
        }
    }
}