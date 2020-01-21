namespace Features.Components
{
    using Entitas;
    using Entitas.CodeGeneration.Attributes;

    [Game, Event(EventTarget.Any)]
    public sealed class ConstructionDoneComponent : IComponent
    {
    }
}