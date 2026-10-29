using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    
    [SerializeField] private int maxHealth;
    public int CurrentHealth { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TODO: Cambiar más tarde a algo mejor
        CurrentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }

    public void Heal(int heal)
    {
        CurrentHealth += heal;
    }
    
    private void CheckAlive()
    {
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            Debug.Log("Game Over");
        }
    }
    
}
