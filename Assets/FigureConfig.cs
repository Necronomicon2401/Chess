using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigureConfig : ScriptableObject
    {
        [SerializeField] private FigureInfo[] figures;

        public FigureInfo[] Figures => figures;
        
        public FigureInfo[] GetWhiteFigures()
        {
            return figures.Where(figure => figure.Color == "White").ToArray();
        }
        
        public FigureInfo[] GetBlackFigures()
        {
            return figures.Where(figure => figure.Color == "Black").ToArray();
        }


        public string[] GetFiguresId()
        {
            return figures.Select(f => f.ID).ToArray();
        }

        public FigureInfo GetFigureInfo(string id)
        {
            return figures.FirstOrDefault(f => f.ID == id);
        }
        
        public FigureInfo GetFigureInfoByType(string type)
        {
            return figures.FirstOrDefault(f => f.Type == type);
        }
    }
}