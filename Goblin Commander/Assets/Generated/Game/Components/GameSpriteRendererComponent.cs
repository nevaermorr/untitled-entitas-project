//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpriteRendererComponent spriteRenderer { get { return (SpriteRendererComponent)GetComponent(GameComponentsLookup.SpriteRenderer); } }
    public bool hasSpriteRenderer { get { return HasComponent(GameComponentsLookup.SpriteRenderer); } }

    public void AddSpriteRenderer(UnityEngine.SpriteRenderer newValue) {
        var index = GameComponentsLookup.SpriteRenderer;
        var component = CreateComponent<SpriteRendererComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpriteRenderer(UnityEngine.SpriteRenderer newValue) {
        var index = GameComponentsLookup.SpriteRenderer;
        var component = CreateComponent<SpriteRendererComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpriteRenderer() {
        RemoveComponent(GameComponentsLookup.SpriteRenderer);
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

    static Entitas.IMatcher<GameEntity> _matcherSpriteRenderer;

    public static Entitas.IMatcher<GameEntity> SpriteRenderer {
        get {
            if (_matcherSpriteRenderer == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpriteRenderer);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpriteRenderer = matcher;
            }

            return _matcherSpriteRenderer;
        }
    }
}