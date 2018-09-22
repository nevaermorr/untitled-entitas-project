//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SwitchBeaconActionRequest switchBeaconActionRequest { get { return (SwitchBeaconActionRequest)GetComponent(GameComponentsLookup.SwitchBeaconActionRequest); } }
    public bool hasSwitchBeaconActionRequest { get { return HasComponent(GameComponentsLookup.SwitchBeaconActionRequest); } }

    public void AddSwitchBeaconActionRequest(BeaconAction newNewBeaconAction) {
        var index = GameComponentsLookup.SwitchBeaconActionRequest;
        var component = CreateComponent<SwitchBeaconActionRequest>(index);
        component.NewBeaconAction = newNewBeaconAction;
        AddComponent(index, component);
    }

    public void ReplaceSwitchBeaconActionRequest(BeaconAction newNewBeaconAction) {
        var index = GameComponentsLookup.SwitchBeaconActionRequest;
        var component = CreateComponent<SwitchBeaconActionRequest>(index);
        component.NewBeaconAction = newNewBeaconAction;
        ReplaceComponent(index, component);
    }

    public void RemoveSwitchBeaconActionRequest() {
        RemoveComponent(GameComponentsLookup.SwitchBeaconActionRequest);
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

    static Entitas.IMatcher<GameEntity> _matcherSwitchBeaconActionRequest;

    public static Entitas.IMatcher<GameEntity> SwitchBeaconActionRequest {
        get {
            if (_matcherSwitchBeaconActionRequest == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SwitchBeaconActionRequest);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSwitchBeaconActionRequest = matcher;
            }

            return _matcherSwitchBeaconActionRequest;
        }
    }
}
