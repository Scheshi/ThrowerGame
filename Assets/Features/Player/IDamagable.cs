namespace Features.Player
{
    public interface IDamagable
    {
        public int CurrentHealth { get; }
        
        public int CurrentArmor { get; }

        public void Damage(int damage, bool isArmorIgnore);
    }
}