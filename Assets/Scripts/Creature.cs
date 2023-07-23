using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature
{
    public string name;
    public string gender;
    public int age;
    public int power;

    public virtual string nameCreature()
    {
        name = "Creature";
        return name;
    }

    public virtual string genderCreature(int genderType)
    {
        if (genderType == 1)
        {
            gender = "Male";
        }
        else if (genderType == 2)
        {
            gender = "Female";
        }
        else
        {
            Debug.LogError("You can only use 1 for Male and 2 for Female");
        }
        return gender;
    }

    public virtual int ageCreature()
    {
        age = 0;
        return age;
    }

    public virtual int powerCreature()
    {
        power = 0;
        return power;
    }
}
