using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject[] bubblePrefabs;
    public float spawnInterval = 2f;
    public float spawnRangeX = 5f; // Giới hạn vùng spawn trên trục X
    public float spawnHeight = -5f; // Vị trí cố định trên trục Y

    void Start()
    {
        InvokeRepeating(nameof(SpawnBubble), 0f, spawnInterval);
    }

    void SpawnBubble()
    {
        if (bubblePrefabs.Length == 0)
        {
            Debug.LogWarning("Chưa có prefab nào trong mảng bubblePrefabs!");
            return;
        }

        // Chọn một prefab ngẫu nhiên từ mảng
        GameObject randomBubblePrefab = bubblePrefabs[Random.Range(0, bubblePrefabs.Length)];

        // Xác định vị trí spawn ngẫu nhiên trên trục X
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        // Tạo đối tượng từ prefab
        Instantiate(randomBubblePrefab, spawnPosition, Quaternion.identity);
    }

    // Vẽ Gizmos trong Scene để hiển thị vùng spawn
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green; // Màu sắc của vùng spawn
        Vector3 center = new Vector3(0f, spawnHeight, 0f);
        Vector3 size = new Vector3(spawnRangeX * 2, 0.1f, 1f); // Chiều dài vùng spawn dựa trên spawnRangeX
        Gizmos.DrawWireCube(center, size); // Vẽ vùng spawn là một hình chữ nhật rỗng
    }
}


