//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public HitPointRegenerationRateComponent hitPointRegenerationRate { get { return (HitPointRegenerationRateComponent)GetComponent(CoreComponentIds.HitPointRegenerationRate); } }
        public bool hasHitPointRegenerationRate { get { return HasComponent(CoreComponentIds.HitPointRegenerationRate); } }

        public Entity AddHitPointRegenerationRate(float newValue) {
            var component = CreateComponent<HitPointRegenerationRateComponent>(CoreComponentIds.HitPointRegenerationRate);
            component.value = newValue;
            return AddComponent(CoreComponentIds.HitPointRegenerationRate, component);
        }

        public Entity ReplaceHitPointRegenerationRate(float newValue) {
            var component = CreateComponent<HitPointRegenerationRateComponent>(CoreComponentIds.HitPointRegenerationRate);
            component.value = newValue;
            ReplaceComponent(CoreComponentIds.HitPointRegenerationRate, component);
            return this;
        }

        public Entity RemoveHitPointRegenerationRate() {
            return RemoveComponent(CoreComponentIds.HitPointRegenerationRate);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherHitPointRegenerationRate;

        public static IMatcher HitPointRegenerationRate {
            get {
                if(_matcherHitPointRegenerationRate == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.HitPointRegenerationRate);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherHitPointRegenerationRate = matcher;
                }

                return _matcherHitPointRegenerationRate;
            }
        }
    }
