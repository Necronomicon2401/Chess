using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class MovementInfo : ScriptableObject
    {
        // "forward" etc
        [SerializeField] private string type;
        [SerializeField] private string movement;
    }
}