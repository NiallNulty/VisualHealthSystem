using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 4;

    [SerializeField] private Text healthText;
    [SerializeField] private GameObject visualHealthObject;
    [SerializeField] private Material healthTwoMaterial;
    [SerializeField] private Material healthThreeMaterial;
    [SerializeField] private Material healthFourMaterial;


    private void Start()
    {
        SetMaterial();
        healthText.text = "Health: " + health.ToString();
    }

    public int Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
        }

        SetMaterial();
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

        SetMaterial();
        healthText.text = "Health: " + health.ToString();

        return health;
    }

    private void SetMaterial()
    {
        if (health == 1 || health == 0)
        {
            visualHealthObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            visualHealthObject.GetComponent<MeshRenderer>().enabled = true;
        }

        if (health == 2)
        {
            visualHealthObject.GetComponent<MeshRenderer>().material = healthTwoMaterial;
        }

        if (health == 3)
        {
            visualHealthObject.GetComponent<MeshRenderer>().material = healthThreeMaterial;
        }

        if (health == 4)
        {
            visualHealthObject.GetComponent<MeshRenderer>().material = healthFourMaterial;
        }
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
