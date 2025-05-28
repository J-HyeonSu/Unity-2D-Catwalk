using UnityEngine;

public class CatController : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 10f;
    
    
    void Awake()
    {
        catRb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
}
