using Interfaces;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    HealthComponent _healthComponent;
        
    
    #region Stats region
    
    [Header("Player base Stats")]
    [SerializeField] private Stats playerStats;
    
    //Stats multipliers

    public int extraHealth;
    public float attackMultiplier;
    public float defenseMultiplier;
    public float attackSpeedMultiplier;
    
    // Final Stats 
    public int totalHealth;
    public float totalAttackDamage;
    public float totalDefense;
    public float totalAttackSpeed;
    
    #endregion    
    
    private void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
            
    }

    private void Start()
    {
        totalHealth = playerStats.maxHealth + extraHealth;
        totalAttackDamage = playerStats.attackDamage * attackMultiplier;
        totalDefense = playerStats.defense * defenseMultiplier;
        totalAttackSpeed = playerStats.attackSpeed * attackSpeedMultiplier;
    }



    #region HealthComponent

    public void TakeDamage(int damage)
    {
        _healthComponent.TakeDamage(damage); 
    }

    public void Heal(int heal)
    {
        _healthComponent.Heal(heal);
    }

    #endregion
        
}