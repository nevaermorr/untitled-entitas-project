//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BeaconRangeComponent beaconRange { get { return (BeaconRangeComponent)GetComponent(GameComponentsLookup.BeaconRange); } }
    public bool hasBeaconRange { get { return HasComponent(GameComponentsLookup.BeaconRange); } }

    public void AddBeaconRange(float newValue) {
        var index = GameComponentsLookup.BeaconRange;
        var component = CreateComponent<BeaconRangeComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBeaconRange(float newValue) {
        var index = GameComponentsLookup.BeaconRange;
        var component = CreateComponent<BeaconRangeComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBeaconRange() {
        RemoveComponent(GameComponentsLookup.BeaconRange);
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

    static Entitas.IMatcher<GameEntity> _matcherBeaconRange;

    public static Entitas.IMatcher<GameEntity> BeaconRange {
        get {
            if (_matcherBeaconRange == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BeaconRange);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBeaconRange = matcher;
            }

            return _matcherBeaconRange;
        }
    }
}