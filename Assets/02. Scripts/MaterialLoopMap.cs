using UnityEngine;

public class MaterialLoopMap : MonoBehaviour
{

    private MeshRenderer renderer;
    public float offsetSpeed = 0.1f;
    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;
        renderer.material.SetTextureOffset("_MainTex", renderer.material.mainTextureOffset+offset);
    }
}
