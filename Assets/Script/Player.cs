using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject arrowPrefab; // Gắn Prefab mũi tên tại đây
    public Transform shootPoint;   // Vị trí tay trái của Player
    public float speed = 5f;       // Tốc độ di chuyển của Player
    public float arrowSpeed = 15f; // Tốc độ bắn của mũi tên
    public float arrowLifetime = 3f; // Thời gian tồn tại của mũi tên

    void Update()
    {
        // Di chuyển Player lên/xuống
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * moveY * speed * Time.deltaTime);

        // Bắn mũi tên khi ấn phím Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // Tạo mũi tên tại vị trí shootPoint
        GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, Quaternion.identity);

        // Di chuyển mũi tên sang phải và hủy sau `arrowLifetime`
        arrow.GetComponent<Rigidbody2D>().linearVelocity = Vector2.right * arrowSpeed;
        Destroy(arrow, arrowLifetime); // Hủy mũi tên sau thời gian chỉ định
    }
}

