namespace SceneLessLogic.Beatmaps.Events
{
    public record EnemyEvent : Event
    {
        public int KillKey { get; set; }

        public float Rotation { get; set; }

        public float RotationSpeed { get; set; }
    }
}