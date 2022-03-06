using UnityEngine;


namespace Features.Player
{
    /// <summary>
    /// Managing the calculation of the number of lives and armor
    /// </summary>
    public class PlayerDamagableController: MonoBehaviour, IDamagable
    {
        [SerializeField] private PlayerData data;
        
        public int CurrentHealth { get; private set; }
        public int CurrentArmor { get; private set; }

        private void Start()
        {
            CurrentHealth = data.MaxHp;
            CurrentArmor = data.MaxArmor;
        }

        public void Damage(int damage, bool isArmorIgnore)
        {
            if (CurrentArmor > 0 && !isArmorIgnore)
                CurrentArmor -= damage;
            else
                CurrentHealth -= damage;
        }
    }
}