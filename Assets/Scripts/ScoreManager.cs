using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Text scoreText;
    void Update()
    {
        scoreText.text = (43f + playerTransform.position.z).ToString("0"); // player z pozisyonu -43 oldugundan toplama islemi yaptim
    }
}
