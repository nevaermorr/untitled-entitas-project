//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public OrientationComponent orientation { get { return (OrientationComponent)GetComponent(GameComponentsLookup.Orientation); } }
    public bool hasOrientation { get { return HasComponent(GameComponentsLookup.Orientation); } }

    public void AddOrientation(OriginalOrientation newValue) {
        var index = GameComponentsLookup.Orientation;
        var component = CreateComponent<OrientationComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceOrientation(OriginalOrientation newValue) {
        var index = GameComponentsLookup.Orientation;
        var component = CreateComponent<OrientationComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveOrientation() {
        RemoveComponent(GameComponentsLookup.Orientation);
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

    static Entitas.IMatcher<GameEntity> _matcherOrientation;

    public static Entitas.IMatcher<GameEntity> Orientation {
        get {
            if (_matcherOrientation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Orientation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherOrientation = matcher;
            }

            return _matcherOrientation;
        }
    }
}
