using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu]
public class FigureInfo : ScriptableObject
{
    [SerializeField] private string type;
    [SerializeField] private string id;
    [SerializeField] private GameObject prefab;
    [SerializeField] private string color;
    [SerializeField] private MovementInfo movementInfo;

    public string Type => type;

    public string ID => id;

    public GameObject Prefab => prefab;

    public string Color
    {
        get => color;
        set => color = value;
    }

    public MovementInfo MovementInfo => movementInfo;
}
