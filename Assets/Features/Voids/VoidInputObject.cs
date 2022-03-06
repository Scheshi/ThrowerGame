using UnityEngine;

namespace Features.Voids
{
    public class VoidInputObject: MonoBehaviour
    {
        public void OnMove(float xAxis, float zAxis)
        {
            Debug.LogFormat("X Axis: {0}, Z Axis: {1}", xAxis, zAxis);
        }

        public void OnThrow()
        {
            Debug.Log("Throw");
        }
    }
}