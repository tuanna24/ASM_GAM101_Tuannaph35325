using UnityEngine;

public class BossScript : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Kiểm tra nếu boss đã bị mất hết máu
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Xử lý khi boss mất
        Destroy(gameObject);
    }
}
