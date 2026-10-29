using UnityEngine;

[CreateAssetMenu(fileName = "New Stats", menuName = "Scriptable Objects/Stats")]
public class Stats : ScriptableObject
{
    
    [Header("Stats")]
    public string entityName;
    
    public int maxHealth;
    public int attackDamage;
    public int defense;
    public float attackSpeed;

    
    
}
