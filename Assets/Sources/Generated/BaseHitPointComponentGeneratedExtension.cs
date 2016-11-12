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

        public BaseHitPointComponent baseHitPoint { get { return (BaseHitPointComponent)GetComponent(CoreComponentIds.BaseHitPoint); } }
        public bool hasBaseHitPoint { get { return HasComponent(CoreComponentIds.BaseHitPoint); } }

        public Entity AddBaseHitPoint(int newAmount) {
            var component = CreateComponent<BaseHitPointComponent>(CoreComponentIds.BaseHitPoint);
            component.amount = newAmount;
            return AddComponent(CoreComponentIds.BaseHitPoint, component);
        }

        public Entity ReplaceBaseHitPoint(int newAmount) {
            var component = CreateComponent<BaseHitPointComponent>(CoreComponentIds.BaseHitPoint);
            component.amount = newAmount;
            ReplaceComponent(CoreComponentIds.BaseHitPoint, component);
            return this;
        }

        public Entity RemoveBaseHitPoint() {
            return RemoveComponent(CoreComponentIds.BaseHitPoint);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherBaseHitPoint;

        public static IMatcher BaseHitPoint {
            get {
                if(_matcherBaseHitPoint == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.BaseHitPoint);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherBaseHitPoint = matcher;
                }

                return _matcherBaseHitPoint;
            }
        }
    }
