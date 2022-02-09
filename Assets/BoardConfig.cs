using System;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class BoardConfig : ScriptableObject
    {
        [SerializeField] private GameObject gameObject;
        public Vector3[,] cellPosition;

        private void OnEnable()
        {
            cellPosition = new Vector3[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Position of first cell
                    var position = gameObject.transform.position;
                    cellPosition[i, j] = new Vector3(position.x + i,
                        position.y, position.z + j);
                }
            }
        }
        
    }
}