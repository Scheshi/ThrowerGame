using UnityEngine;

namespace Features.Inputer
{
    /// <summary>
    /// Implementation of inputer for keyboard control
    /// </summary>
    public class KeyboardInputer: AbstractInputer
    {
        [SerializeField] private KeyboardInputData data;
        
        protected override void OnWillMove(int playerIndex, out float xAxis, out float zAxis)
        {
            xAxis = Input.GetAxis(playerIndex == 1 ? data.XAxisPlayerOneMove : data.XAxisPlayerTwoMove);
            zAxis = Input.GetAxis(playerIndex == 1 ? data.ZAxisPlayerOneMove : data.ZAxisPlayerTwoMove);
        }

        protected override bool OnWillThrow(int playerIndex)
        {
            return Input.GetButtonDown(playerIndex == 1 ? data.ThrowPlayerOneAxis : data.ThrowPlayerTwoAxis);
        }
    }
}