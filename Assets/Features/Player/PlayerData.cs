using UnityEngine;

namespace Features.Player
{
    [CreateAssetMenu(menuName = "ThrowerGame/Datas/" + nameof(PlayerData),
        fileName = nameof(PlayerData))]
    public class PlayerData: ScriptableObject
    {
        [SerializeField] private float throwForce;

        public float ThrowForce
        {
            get => throwForce;
            set => throwForce = value;
        }
    }
}