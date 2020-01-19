namespace Features.MapObject.Placement
{
    using System.Collections.Generic;
    using Config;
    using Entitas;
    using UnityEngine;

    public class ResidencePlacementProcessSystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _gameContext;

        public ResidencePlacementProcessSystem(Contexts contexts) : base(contexts.game)
        {
            _gameContext = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.TransactionDone);

        protected override bool Filter(GameEntity entity) => entity.isTransactionSuccess &&
                                                             entity.hasTransactionMapObject &&
                                                             entity.transactionMapObject.MapObject ==
                                                             MapObject.Residence;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                var isConfigAvailable = ConfigHelper.TryGetConfig(gameEntity.transactionMapObject.MapObject.ToString(),
                    out var config);

                if (isConfigAvailable)
                {
                    var productionEntity = _gameContext.CreateEntity();
                    var production = new ProductionData
                    {
                        MapObject = config.MapObject,
                        TimeLeft = config.ProductionDuration,
                        IsInProduction = false,
                        IsAuto = config.Auto
                    };
                    productionEntity.AddProduction(production);
                    productionEntity.AddConstruction(config.ProductionDelay);
                }
            }
        }
    }
}