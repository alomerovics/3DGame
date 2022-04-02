using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Vector3 offset;
    void Update()
    {
        transform.position = playerTransform.transform.position + offset; // kameran�n pozisyonunu player'in pozisyonuna esitle. Kamera player i takip etsin
    }
}
