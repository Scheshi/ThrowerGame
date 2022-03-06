using UnityEngine;

namespace Features.Weapon
{
    [CreateAssetMenu(menuName = "ThrowerGame/Datas/" + nameof(WeaponData),
        fileName = nameof(WeaponData))]
    public class WeaponData: ScriptableObject
    {
        [SerializeField] private int damage;
        [SerializeField] private bool isArmorIgnore;

        public int Damage => damage;
        public bool IsArmorIgnore => isArmorIgnore;
    }
}