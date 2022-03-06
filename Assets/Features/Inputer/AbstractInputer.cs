using UnityEngine;
using UnityEngine.Events;

namespace Features.Inputer
{
    /// <summary>
    /// Input abstraction for players control
    /// </summary>
    public abstract class AbstractInputer : MonoBehaviour
    {
        [Header("First player input")]
        [SerializeField] private UnityEvent<float, float> onMove;
        [SerializeField] private UnityEvent onThrow;

        [Header("Second player input")]
        [SerializeField] private UnityEvent<float, float> onMoveSecond;
        [SerializeField] private UnityEvent onThrowSecond;
        
        [Header("Can move axis")] 
        [SerializeField] private bool isCanXAxisMove;
        [SerializeField] private bool isCanZAxisMove;

        protected virtual void Update()
        {
            OnWillMove(1, out float xAxis, out float zAxis);
            onMove.Invoke(
                isCanXAxisMove ? xAxis : 0,
                isCanZAxisMove ? zAxis : 0
                );
            if(OnWillThrow(1))
                onThrow.Invoke();
            
            OnWillMove(2, out xAxis, out zAxis);
            onMoveSecond.Invoke(
                isCanXAxisMove ? xAxis : 0,
                isCanZAxisMove ? zAxis : 0
            );
            if(OnWillThrow(2))
                onThrowSecond.Invoke();
        }

        protected abstract void OnWillMove(int playerIndex, out float xAxis, out float zAxis);
        protected abstract bool OnWillThrow(int playerIndex);
    }
}
