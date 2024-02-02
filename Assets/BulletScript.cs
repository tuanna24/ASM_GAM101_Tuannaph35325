using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public int damage = 3;

    void Update()
    {
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            // Truyền damage vào boss
            other.GetComponent<BossScript>().TakeDamage(damage);
            
            // Huỷ đạn sau khi va chạm với boss
            Destroy(gameObject);
        }
    }
}
