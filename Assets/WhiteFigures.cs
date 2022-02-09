using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class WhiteFigures : MonoBehaviour
    {
        [SerializeField] private FigureConfig _figureConfig;
        [SerializeField] private BoardConfig _boardConfig;
        [SerializeField] private GameObject board;

        private FigureInfo[] whiteFigures;

        private void OnEnable()
        {
            whiteFigures = _figureConfig.GetWhiteFigures();
        }

        private void SetWhiteFigures()
        {
            
        }
    }
}