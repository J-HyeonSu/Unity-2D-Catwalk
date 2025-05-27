using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (transform.position.x <= -30f)
        {
            transform.position = new Vector3(transform.position.x+60f, transform.position.y, 0f);
        }
        
    }
}
