using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
   [HideInInspector]
    public string Characters = "Idle";
    [Header("Перс.Характеристики")]
    [SerializeField] private int _maxHP;
    [SerializeField] private int _minHP;
    private int currentHP;
    [Header("Перс.Свойства")]
    [SerializeField] [Range(1,7)]private int _damage;
    [SerializeField] [Range(0.5f, 17.3f)][Space]private float _velocity;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
