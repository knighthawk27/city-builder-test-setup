//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Features.Components.ProductionPercentDoneComponent productionPercentDone { get { return (Features.Components.ProductionPercentDoneComponent)GetComponent(GameComponentsLookup.ProductionPercentDone); } }
    public bool hasProductionPercentDone { get { return HasComponent(GameComponentsLookup.ProductionPercentDone); } }

    public void AddProductionPercentDone(float newValue) {
        var index = GameComponentsLookup.ProductionPercentDone;
        var component = (Features.Components.ProductionPercentDoneComponent)CreateComponent(index, typeof(Features.Components.ProductionPercentDoneComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProductionPercentDone(float newValue) {
        var index = GameComponentsLookup.ProductionPercentDone;
        var component = (Features.Components.ProductionPercentDoneComponent)CreateComponent(index, typeof(Features.Components.ProductionPercentDoneComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProductionPercentDone() {
        RemoveComponent(GameComponentsLookup.ProductionPercentDone);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherProductionPercentDone;

    public static Entitas.IMatcher<GameEntity> ProductionPercentDone {
        get {
            if (_matcherProductionPercentDone == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ProductionPercentDone);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherProductionPercentDone = matcher;
            }

            return _matcherProductionPercentDone;
        }
    }
}
