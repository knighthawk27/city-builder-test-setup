//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyProductionPercentDoneListenerComponent anyProductionPercentDoneListener { get { return (AnyProductionPercentDoneListenerComponent)GetComponent(GameComponentsLookup.AnyProductionPercentDoneListener); } }
    public bool hasAnyProductionPercentDoneListener { get { return HasComponent(GameComponentsLookup.AnyProductionPercentDoneListener); } }

    public void AddAnyProductionPercentDoneListener(System.Collections.Generic.List<IAnyProductionPercentDoneListener> newValue) {
        var index = GameComponentsLookup.AnyProductionPercentDoneListener;
        var component = (AnyProductionPercentDoneListenerComponent)CreateComponent(index, typeof(AnyProductionPercentDoneListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyProductionPercentDoneListener(System.Collections.Generic.List<IAnyProductionPercentDoneListener> newValue) {
        var index = GameComponentsLookup.AnyProductionPercentDoneListener;
        var component = (AnyProductionPercentDoneListenerComponent)CreateComponent(index, typeof(AnyProductionPercentDoneListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyProductionPercentDoneListener() {
        RemoveComponent(GameComponentsLookup.AnyProductionPercentDoneListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAnyProductionPercentDoneListener;

    public static Entitas.IMatcher<GameEntity> AnyProductionPercentDoneListener {
        get {
            if (_matcherAnyProductionPercentDoneListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyProductionPercentDoneListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyProductionPercentDoneListener = matcher;
            }

            return _matcherAnyProductionPercentDoneListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyProductionPercentDoneListener(IAnyProductionPercentDoneListener value) {
        var listeners = hasAnyProductionPercentDoneListener
            ? anyProductionPercentDoneListener.value
            : new System.Collections.Generic.List<IAnyProductionPercentDoneListener>();
        listeners.Add(value);
        ReplaceAnyProductionPercentDoneListener(listeners);
    }

    public void RemoveAnyProductionPercentDoneListener(IAnyProductionPercentDoneListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyProductionPercentDoneListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyProductionPercentDoneListener();
        } else {
            ReplaceAnyProductionPercentDoneListener(listeners);
        }
    }
}