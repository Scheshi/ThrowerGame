namespace Features.Player
{
    /// <summary>
    /// Interface for marking an object taking damage
    /// </summary>
    public interface IDamagable
    {
        public int CurrentHealth { get; }
        
        public int CurrentArmor { get; }

        /// <summary>
        /// Make damage
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="isArmorIgnore"></param>
        public void Damage(int damage, bool isArmorIgnore);
    }
}