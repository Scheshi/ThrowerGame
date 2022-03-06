using UnityEngine;
using UnityEngine.Events;

namespace Features.Inputer
{
    public abstract class AbstractInputer : MonoBehaviour
    {
        [SerializeField] private UnityEvent<float, float> onMove;
        [SerializeField] private UnityEvent onThrow;

        [Header("Can move axis")] 
        [SerializeField] private bool isCanXAxisMove;
        [SerializeField] private bool isCanZAxisMove;

        protected virtual void Update()
        {
            OnWillMove(out float xAxis, out float zAxis);
            onMove.Invoke(
                isCanXAxisMove ? xAxis : 0,
                isCanZAxisMove ? zAxis : 0
                );
            if(OnWillThrow())
                onThrow.Invoke();
        }

        protected abstract void OnWillMove(out float xAxis, out float zAxis);
        protected abstract bool OnWillThrow();
    }
}
