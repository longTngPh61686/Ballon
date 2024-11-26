using UnityEngine;

public class Circle : MonoBehaviour
{
    void Start()
    {
        // Lấy thành phần Rigidbody2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Tạo giá trị ngẫu nhiên từ -0.5 đến 1f
            float randomGravityScale = Random.Range(-0.5f, -1f);

            // Gán giá trị ngẫu nhiên cho Gravity Scale
            rb.gravityScale = randomGravityScale;

            Debug.Log("Gravity Scale mới: " + randomGravityScale);
        }
        else
        {
            Debug.LogWarning("Rigidbody2D không được tìm thấy!");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("end"))
        {
            // Hủy đối tượng này
            Destroy(gameObject);
            Debug.Log("Circle đã bị hủy!");
        }
    }
}
