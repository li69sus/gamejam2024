using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;
    public GameObject healthBarUi;
    private HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = healthBarUi.GetComponent<HealthBar>();
        healthBar.SetMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if ( CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
        healthBar.SetHealth(CurrentHealth);
    }
}
