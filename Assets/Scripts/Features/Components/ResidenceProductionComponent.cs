namespace Features.Components
{
    using Config;
    using Entitas;
    using Entitas.CodeGeneration.Attributes;

    [Game]
    public class ResidenceProductionComponent : IComponent
    {
        public bool IsInProduction;
        public float TimeLeft;
        public ProductionBuilding Building;
        public string ProductionId;
    }
}