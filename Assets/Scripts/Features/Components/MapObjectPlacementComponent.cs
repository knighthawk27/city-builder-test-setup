namespace Features.Components
{
    using Config;
    using Entitas;
    using Entitas.CodeGeneration.Attributes;

    [Game, Unique]
    public sealed class MapObjectPlacementComponent :IComponent
    {
        public MapObject Value;
    }
}