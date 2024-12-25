using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    public static GameObject[] Shovels { get; }
    
    public static GameObject[] Pumpkins { get; }
    
    public static GameObject[] Graves { get; }
    
    public static List<Gravestone> Gravestones { get; }
    
    public static List<GA_Zombie> Zombies { get; }

    static GWorld()
    {
        world = new WorldStates();
        
        Shovels = GameObject.FindGameObjectsWithTag("Shovel");
        Pumpkins = GameObject.FindGameObjectsWithTag("Pumpkin");
        Graves = GameObject.FindGameObjectsWithTag("Grave");
        
        
        Gravestones = new List<Gravestone>();
        Gravestones.AddRange(GameObject.FindObjectsByType<Gravestone>(FindObjectsSortMode.None));
        
        Zombies = new List<GA_Zombie>();
        Zombies.AddRange(GameObject.FindObjectsByType<GA_Zombie>(FindObjectsSortMode.None));
    }

    private GWorld()
    {
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}