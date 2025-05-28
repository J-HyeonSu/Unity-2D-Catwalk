using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class ColliderEvent : MonoBehaviour
{
    [Header("장애물 설정")]
    public GameObject Obstacle; 
    public float spawnRate = 2f; // 스폰 간격 (초)
    public float obstacleSpeed = 3f; // 장애물 이동 속도
    
    [Header("간격 설정")]
    public float minGap = 3f; // 최소 간격
    public float maxGap = 5f; // 최대 간격
    public float obstacleHeight = 8f; // 기둥 높이
    
    [Header("스폰 위치")]
    public float spawnX = 10f; // 스폰 X 위치
    public float minY = -2f; // 최소 Y 위치
    public float maxY = 2f; // 최대 Y 위치
    
    private float nextSpawnTime;
    
    void Start()
    {
        nextSpawnTime = Time.time + spawnRate;
    }
    
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnRate;
        }
    }
    
    void SpawnObstacle()
    {
        // 랜덤 간격과 높이 계산
        float randomGap = Random.Range(minGap, maxGap);
        float randomY = Random.Range(minY, maxY);
        
        // 위쪽 기둥 생성
        Vector3 topPos = new Vector3(spawnX, randomY + randomGap/2 + obstacleHeight/2, 0);
        GameObject topObstacle = Instantiate(Obstacle, topPos, Quaternion.Euler(0, 0, 180));
        
        // 아래쪽 기둥 생성
        Vector3 bottomPos = new Vector3(spawnX, randomY - randomGap/2 - obstacleHeight/2, 0);
        GameObject bottomObstacle = Instantiate(Obstacle, bottomPos, Quaternion.identity);
        
        // 장애물 이동 스크립트 추가
        topObstacle.AddComponent<ObstacleMove>().speed = obstacleSpeed;
        bottomObstacle.AddComponent<ObstacleMove>().speed = obstacleSpeed;
    }
}