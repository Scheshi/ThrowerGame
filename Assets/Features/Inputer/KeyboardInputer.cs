using UnityEngine;

namespace Features.Inputer
{
    public class KeyboardInputer: AbstractInputer
    {
        [SerializeField] private KeyboardInputData data;
        
        protected override void OnWillMove(out float xAxis, out float zAxis)
        {
            xAxis = Input.GetAxis(data.XAxisMove);
            zAxis = Input.GetAxis(data.ZAxisMove);
        }

        protected override bool OnWillThrow()
        {
            return Input.GetButtonDown(data.ThrowAxis);
        }
    }
}