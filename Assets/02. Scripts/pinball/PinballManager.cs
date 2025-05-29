using UnityEngine;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;

    public float tq = 30f;
    public float score;
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftBarRb.AddTorque(tq);
        }
        else
        {
            leftBarRb.AddTorque(-tq);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightBarRb.AddTorque(-tq);
        }
        else
        {
            rightBarRb.AddTorque(tq);
        }
    }
}
