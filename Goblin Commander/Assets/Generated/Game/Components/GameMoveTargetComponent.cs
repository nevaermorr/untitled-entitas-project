//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MoveTargetComponent moveTarget { get { return (MoveTargetComponent)GetComponent(GameComponentsLookup.MoveTarget); } }
    public bool hasMoveTarget { get { return HasComponent(GameComponentsLookup.MoveTarget); } }

    public void AddMoveTarget(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.MoveTarget;
        var component = CreateComponent<MoveTargetComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMoveTarget(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.MoveTarget;
        var component = CreateComponent<MoveTargetComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveTarget() {
        RemoveComponent(GameComponentsLookup.MoveTarget);
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

    static Entitas.IMatcher<GameEntity> _matcherMoveTarget;

    public static Entitas.IMatcher<GameEntity> MoveTarget {
        get {
            if (_matcherMoveTarget == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveTarget);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveTarget = matcher;
            }

            return _matcherMoveTarget;
        }
    }
}
