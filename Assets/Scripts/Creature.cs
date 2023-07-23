using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
[Serializable]
public class Creature
{
    public string name;
    public string gender;
    public int age;
    public int power;
    public string element;

    // Metodo virtual que se sobreescribe en las clases hijas para obtener el genero de la criatura
    // solo se puede usar 1 para macho y 2 para hembra
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

    // Metodo virtual que se sobreescribe en las clases hijas para obtener la edad de la criatura
    public virtual int ageCreature()
    {
        age = 0;
        return age;
    }

    // Metodo virtual que se sobreescribe en las clases hijas para obtener el poder de la criatura
    public virtual int powerCreature()
    {
        power = 0;
        return power;
    }

    // Metodo virtual que se sobreescribe en las clases hijas para obtener el elemento de la criatura
    public virtual string elementCreature()
    {
        element = "Element";
        return element;
    }

    // Metodo virtual que se sobreescribe en las clases hijas para obtener la habilidad de la criatura
    public virtual string getAbility()
    {
        return "Ability";
    }

    // Metodo virtual que se sobreescribe en las clases hijas para obtener el alimento de la criatura
    public virtual string getFood()
    {
        return "Food";
    }

    // Metodo para obtener un nombre aleatorio de un archivo json
    protected string GetRandomName()
    {
        string path = "Assets/Data/CreatureData.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            CreatureNames creatureNames = JsonUtility.FromJson<CreatureNames>(json);
            Debug.Log(creatureNames.name.Count);
            int randomNameIndex = UnityEngine.Random.Range(0, creatureNames.name.Count);
            return creatureNames.name[randomNameIndex];
        }
        else
        {
            Debug.LogError("File not found");
            return "Creature";
        }
    }


}

// Clase para obtener los nombres de un archivo json
[System.Serializable]
public class CreatureNames
{
    public List<string> name;
}


