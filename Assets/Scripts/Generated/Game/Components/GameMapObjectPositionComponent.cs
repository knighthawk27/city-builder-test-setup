//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Features.Components.MapObjectPosition mapObjectPosition { get { return (Features.Components.MapObjectPosition)GetComponent(GameComponentsLookup.MapObjectPosition); } }
    public bool hasMapObjectPosition { get { return HasComponent(GameComponentsLookup.MapObjectPosition); } }

    public void AddMapObjectPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MapObjectPosition;
        var component = (Features.Components.MapObjectPosition)CreateComponent(index, typeof(Features.Components.MapObjectPosition));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMapObjectPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.MapObjectPosition;
        var component = (Features.Components.MapObjectPosition)CreateComponent(index, typeof(Features.Components.MapObjectPosition));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMapObjectPosition() {
        RemoveComponent(GameComponentsLookup.MapObjectPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherMapObjectPosition;

    public static Entitas.IMatcher<GameEntity> MapObjectPosition {
        get {
            if (_matcherMapObjectPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MapObjectPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMapObjectPosition = matcher;
            }

            return _matcherMapObjectPosition;
        }
    }
}
