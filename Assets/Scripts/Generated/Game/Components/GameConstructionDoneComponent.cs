//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Features.Components.ConstructionDoneComponent constructionDoneComponent = new Features.Components.ConstructionDoneComponent();

    public bool isConstructionDone {
        get { return HasComponent(GameComponentsLookup.ConstructionDone); }
        set {
            if (value != isConstructionDone) {
                var index = GameComponentsLookup.ConstructionDone;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : constructionDoneComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherConstructionDone;

    public static Entitas.IMatcher<GameEntity> ConstructionDone {
        get {
            if (_matcherConstructionDone == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ConstructionDone);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherConstructionDone = matcher;
            }

            return _matcherConstructionDone;
        }
    }
}