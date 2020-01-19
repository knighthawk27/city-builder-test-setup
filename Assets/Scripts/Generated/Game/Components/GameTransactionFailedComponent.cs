//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Features.Components.TransactionFailedComponent transactionFailedComponent = new Features.Components.TransactionFailedComponent();

    public bool isTransactionFailed {
        get { return HasComponent(GameComponentsLookup.TransactionFailed); }
        set {
            if (value != isTransactionFailed) {
                var index = GameComponentsLookup.TransactionFailed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : transactionFailedComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherTransactionFailed;

    public static Entitas.IMatcher<GameEntity> TransactionFailed {
        get {
            if (_matcherTransactionFailed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TransactionFailed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTransactionFailed = matcher;
            }

            return _matcherTransactionFailed;
        }
    }
}
