using UnityEngine;

public class AirCreature : Creature
{
    public AirCreature()
    {
        name = GetRandomName();
    }
    private string ability = "He can fly";
    private string food = "It feeds on oxygen";
    public override string getAbility() => ability;
    public override string getFood() => food;
    public override int ageCreature() => age = Random.Range(1, 100);
    public override int powerCreature() => power = Random.Range(1, 10000);
    public override string elementCreature() => "Air";


}