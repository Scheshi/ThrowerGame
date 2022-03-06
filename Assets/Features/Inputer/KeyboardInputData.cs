using UnityEngine;

namespace Features.Inputer
{
    [CreateAssetMenu(menuName = "ThrowerGame/Datas/" + nameof(KeyboardInputData),
        fileName = nameof(KeyboardInputData))]
    public class KeyboardInputData: ScriptableObject
    {
        [SerializeField] private string xAxisMove = "Horizontal";
        [SerializeField] private string zAxisMove = "Vertical";
        [SerializeField] private string throwAxis = "Fire1";

        public string XAxisMove
        {
            get => xAxisMove;
            set => xAxisMove = value;
        }

        public string ZAxisMove
        {
            get => zAxisMove;
            set => zAxisMove = value;
        }

        public string ThrowAxis
        {
            get => throwAxis;
            set => throwAxis = value;
        }
    }
}