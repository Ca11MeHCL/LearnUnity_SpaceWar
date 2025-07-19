using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance; }
    public static string meteoriteOne = "Meteorite_1";

    protected override void Awake()
    {
        base.Awake();
        JunkSpawner.instance = this;
    }
}
