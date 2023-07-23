using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageCreatureInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text creatureName;
    [SerializeField] private TMP_Text creatureGender;
    [SerializeField] private TMP_Text creatureAge;
    [SerializeField] private TMP_Text creatureElement;
    [SerializeField] private TMP_Text creaturePower;
    [SerializeField] private TMP_Text creatureAbility;
    [SerializeField] private TMP_Text creatureFood;
    private List<Creature> creatures;
    private Creature randomCreature;

    // Start is called before the first frame update
    void Start()
    {
        creatures = new List<Creature>();
        creatures.Add(new CreatureOfFire());
        creatures.Add(new EarthCreature());
        creatures.Add(new CreatureOfWater());
        creatures.Add(new AirCreature());
        creatures.Add(new CreatureOfElectricity());

        randomCreature = creatures[Random.Range(0, creatures.Count)];
        ShowCreatureInfo();
    }

    // Metodo que muestra la informacion de la criatura
    public void ShowCreatureInfo()
    {
        creatureName.text = randomCreature.name;
        creatureGender.text = "Gender : " + randomCreature.genderCreature(Random.Range(1, 3));
        creatureAge.text = "Age : " + randomCreature.ageCreature().ToString();
        creatureElement.text = "Element : " + randomCreature.elementCreature();
        creaturePower.text = "Power : " + randomCreature.powerCreature().ToString();
        creatureAbility.text = "Ability : " + randomCreature.getAbility();
        creatureFood.text = "Food : " + randomCreature.getFood();
    }

    // Metodo que se ejecuta al pulsar el boton de cambiar criatura
    public void ChangeCreature()
    {
        randomCreature = creatures[Random.Range(0, creatures.Count)];
        ShowCreatureInfo();
    }
}
