//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly MouseReleasedComponent mouseReleasedComponent = new MouseReleasedComponent();

    public bool isMouseReleased {
        get { return HasComponent(InputComponentsLookup.MouseReleased); }
        set {
            if (value != isMouseReleased) {
                var index = InputComponentsLookup.MouseReleased;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseReleasedComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMouseReleased;

    public static Entitas.IMatcher<InputEntity> MouseReleased {
        get {
            if (_matcherMouseReleased == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseReleased);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseReleased = matcher;
            }

            return _matcherMouseReleased;
        }
    }
}
