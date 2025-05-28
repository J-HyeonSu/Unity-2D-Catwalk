using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [Header("이동 설정")]
    public float speed = 3f; // 이동 속도
    public float destroyX = -12f; // 삭제될 X 위치
    
    void Update()
    {
        // 왼쪽으로 이동
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        // 화면 밖으로 나가면 삭제
        if (transform.position.x <= destroyX)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // 플레이어와 충돌 시 게임오버
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
        }
    }
}