using UnityEngine;

public class CreatureOfElectricity : Creature
{

    public CreatureOfElectricity()
    {
        name = GetRandomName();
    }
    private string ability = "Control the electricity";
    private string food = "Electricity";

    public override string getAbility() => ability;
    public override string getFood() => food;
    public override int ageCreature() => age = Random.Range(1, 100);
    public override int powerCreature() => power = Random.Range(1, 10000);
    public override string elementCreature() => "Electricity";

}