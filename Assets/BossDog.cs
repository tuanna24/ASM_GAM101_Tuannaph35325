using UnityEngine;

public class BossDog : MonoBehaviour
{
    public float moveSpeed = 2f; // Tốc độ di chuyển của Boss
    public float changeDirectionInterval = 2f; // Khoảng thời gian để thay đổi hướng
    public float rotationSpeed = 180f; // Tốc độ xoay của Boss
    private float timeSinceLastDirectionChange = 0f;
    private int currentDirection = 1; // 1: Di chuyển sang phải, -1: Di chuyển sang trái
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // Sử dụng loại Rigidbody Kinematic để không bị ảnh hưởng bởi lực vật lý khác
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu đối tượng va chạm là nhân vật
        if (other.CompareTag("Player"))
        {
            // Xử lý khi nhân vật va chạm với Boss (ví dụ: không đẩy ra)
            // Ở đây, bạn có thể thêm logic tương ứng với yêu cầu của bạn.

            // Ví dụ: In một thông báo khi va chạm với nhân vật
            Debug.Log("Boss đã va chạm với nhân vật!");
        }
    }

    void Update()
    {
        // Tính toán vị trí mới của Boss dựa trên thời gian và hướng di chuyển
        Vector3 newPosition = transform.position + new Vector3(currentDirection, 0f, 0f) * moveSpeed * Time.deltaTime;

        // Áp dụng vị trí mới thông qua Rigidbody2D
        rb.MovePosition(newPosition);

        // Cập nhật thời gian kể từ lần thay đổi hướng cuối cùng
        timeSinceLastDirectionChange += Time.deltaTime;

        // Kiểm tra xem có đến lúc thay đổi hướng không
        if (timeSinceLastDirectionChange >= changeDirectionInterval)
        {
            // Thay đổi hướng và đặt lại thời gian
            currentDirection *= -1;
            timeSinceLastDirectionChange = 0f;

            // Xoay hình của Boss khi thay đổi hướng
            Vector3 newRotation = transform.rotation.eulerAngles;
            newRotation.y += 180f; // Đổi hướng quay 180 độ
            transform.rotation = Quaternion.Euler(newRotation);
        }
    }
}
