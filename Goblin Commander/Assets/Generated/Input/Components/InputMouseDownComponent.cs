//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly MouseDownComponent mouseDownComponent = new MouseDownComponent();

    public bool isMouseDown {
        get { return HasComponent(InputComponentsLookup.MouseDown); }
        set {
            if (value != isMouseDown) {
                var index = InputComponentsLookup.MouseDown;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseDownComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMouseDown;

    public static Entitas.IMatcher<InputEntity> MouseDown {
        get {
            if (_matcherMouseDown == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseDown);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseDown = matcher;
            }

            return _matcherMouseDown;
        }
    }
}
