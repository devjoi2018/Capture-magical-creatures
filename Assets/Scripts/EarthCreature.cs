using UnityEngine;
public class EarthCreature : Creature
{
    public EarthCreature()
    {
        name = GetRandomName();
    }
    private string ability = "Control the earth";
    private string food = "Earth";
    public override string getAbility() => ability;
    public override string getFood() => food;
    public override int ageCreature() => age = Random.Range(1, 100);
    public override int powerCreature() => power = Random.Range(1, 10000);
    public override string elementCreature() => "Earth";

}