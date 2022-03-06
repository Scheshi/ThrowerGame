using UnityEngine;

namespace Features.Inputer
{
    [CreateAssetMenu(menuName = "ThrowerGame/Datas/" + nameof(KeyboardInputData),
        fileName = nameof(KeyboardInputData))]
    public class KeyboardInputData: ScriptableObject
    {
        [SerializeField] private string xAxisPlayerOneMove = "Horizontal";
        [SerializeField] private string zAxisPlayerOneMove = "Vertical";
        [SerializeField] private string throwPlayerOneAxis = "Fire1";
        [SerializeField] private string xAxisPlayerTwoMove = "Horizontal";
        [SerializeField] private string zAxisPlayerTwoMove = "Vertical";
        [SerializeField] private string throwPlayerTwoAxis = "Fire2";

        public string XAxisPlayerOneMove
        {
            get => xAxisPlayerOneMove;
            set => xAxisPlayerOneMove = value;
        }

        public string ZAxisPlayerOneMove
        {
            get => zAxisPlayerOneMove;
            set => zAxisPlayerOneMove = value;
        }

        public string ThrowPlayerOneAxis
        {
            get => throwPlayerOneAxis;
            set => throwPlayerOneAxis = value;
        }
        
        public string XAxisPlayerTwoMove
        {
            get => xAxisPlayerTwoMove;
            set => xAxisPlayerTwoMove = value;
        }

        public string ZAxisPlayerTwoMove
        {
            get => zAxisPlayerTwoMove;
            set => zAxisPlayerTwoMove = value;
        }

        public string ThrowPlayerTwoAxis
        {
            get => throwPlayerTwoAxis;
            set => throwPlayerTwoAxis = value;
        }
    }
}