using UnityEngine;
public class CreatureOfWater : Creature
{
    public CreatureOfWater()
    {
        name = GetRandomName();
    }
    private string ability = "Control the Sea";
    private string food = "Seaweed";
    public override string getAbility() => ability;
    public override string getFood() => food;
    public override int ageCreature() => age = Random.Range(1, 100);
    public override int powerCreature() => power = Random.Range(1, 10000);
    public override string elementCreature() => "Water";

}