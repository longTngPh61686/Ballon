using UnityEngine;

public class Arrow : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra nếu đối tượng bị va chạm có tag "Balloon"
        if (collision.CompareTag("ballon"))
        {
            Destroy(collision.gameObject); // Hủy đối tượng Balloon
            Destroy(gameObject); // Hủy mũi tên
        }
    }
}
