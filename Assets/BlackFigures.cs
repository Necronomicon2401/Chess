using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class BlackFigures : MonoBehaviour
    {
        [SerializeField] private FigureConfig _figureConfig;
        [SerializeField] private BoardConfig _boardConfig;
        [SerializeField] private GameObject board;

        private FigureInfo[] blackFigures;

        private void OnEnable()
        {
            blackFigures = _figureConfig.GetBlackFigures();
        }

        private void SetWhiteFigures()
        {
            
        }
    }
}