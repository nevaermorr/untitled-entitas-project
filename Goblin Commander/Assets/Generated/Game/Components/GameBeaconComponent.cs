//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BeaconComponent beacon { get { return (BeaconComponent)GetComponent(GameComponentsLookup.Beacon); } }
    public bool hasBeacon { get { return HasComponent(GameComponentsLookup.Beacon); } }

    public void AddBeacon(float newRange) {
        var index = GameComponentsLookup.Beacon;
        var component = CreateComponent<BeaconComponent>(index);
        component.Range = newRange;
        AddComponent(index, component);
    }

    public void ReplaceBeacon(float newRange) {
        var index = GameComponentsLookup.Beacon;
        var component = CreateComponent<BeaconComponent>(index);
        component.Range = newRange;
        ReplaceComponent(index, component);
    }

    public void RemoveBeacon() {
        RemoveComponent(GameComponentsLookup.Beacon);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBeacon;

    public static Entitas.IMatcher<GameEntity> Beacon {
        get {
            if (_matcherBeacon == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Beacon);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBeacon = matcher;
            }

            return _matcherBeacon;
        }
    }
}
