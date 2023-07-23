using UnityEngine;
public class CreatureOfFire : Creature
{
    public CreatureOfFire()
    {
        name = GetRandomName();
    }
    private string ability = "Control the fire";
    private string food = "Volcano lava";
    public override string getAbility() => ability;
    public override string getFood() => food;
    public override int ageCreature() => age = Random.Range(1, 100);
    public override int powerCreature() => power = Random.Range(1, 10000);
    public override string elementCreature() => "Fire";

}