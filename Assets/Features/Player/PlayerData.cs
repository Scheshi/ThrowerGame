using UnityEngine;

namespace Features.Player
{
    [CreateAssetMenu(menuName = "ThrowerGame/Datas/" + nameof(PlayerData),
        fileName = nameof(PlayerData))]
    public class PlayerData: ScriptableObject
    {
        [SerializeField] private float throwForce;
        [SerializeField] private float movingSpeed;
        [SerializeField] private int maxHp;
        [SerializeField] private int maxArmor;
        [SerializeField] private bool isCanTakeThrowingWeapon;
        public float ThrowForce
        {
            get => throwForce;
            set => throwForce = value;
        }

        public float MovingSpeed
        {
            get => movingSpeed;
            set => movingSpeed = value;
        }

        public int MaxHp
        {
            get => maxHp;
            set => maxHp = value;
        }

        public bool IsCanTakeThrowingWeapon
        {
            get => isCanTakeThrowingWeapon;
            set => isCanTakeThrowingWeapon = value;
        }

        public int MaxArmor
        {
            get => maxArmor;
            set => maxArmor = value;
        }
    }
}