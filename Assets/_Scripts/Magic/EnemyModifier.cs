namespace Magic
{
    public interface IEnemyModifier
    {
        /// <summary>
        /// Called when the modifier is added to an enemy and initialized
        /// </summary>
        public void Initialized();

        /// <summary>
        /// This is the update method for the modifier
        /// </summary>
        public bool ModifierUpdate(Health health);
    }
}