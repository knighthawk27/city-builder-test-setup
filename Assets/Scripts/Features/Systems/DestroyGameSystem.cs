namespace Features.Systems
{
    using System.Collections.Generic;
    using Entitas;

    public sealed class DestroyGameSystem : ICleanupSystem
    {
        readonly IGroup<GameEntity> _group;
        readonly List<GameEntity> _buffer = new List<GameEntity>();

        public DestroyGameSystem(Contexts contexts)
        {
            _group = contexts.game.GetGroup(GameMatcher.Destroyed);
        }

        public void Cleanup()
        {
            foreach (var e in _group.GetEntities(_buffer))
            {
                e.Destroy();
            }
        }
    }
}