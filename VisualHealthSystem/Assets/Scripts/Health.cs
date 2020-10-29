using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 4;

    [SerializeField] private Text healthText;

    private void Start()
    {
        healthText.text = "Health: " + health.ToString();
    }

    public int Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
        }

        healthText.text = "Health: " + health.ToString();

        return health;
    }

    public int Heal(int heal)
    {
        health += heal;

        if (health >= 4)
        {
            health = 4;
        }

        healthText.text = "Health: " + health.ToString();

        return health;
    }

    public void DamageTest()
    {
        Damage(1);
    }

    public void HealTest()
    {
        Heal(1);
    }
}
