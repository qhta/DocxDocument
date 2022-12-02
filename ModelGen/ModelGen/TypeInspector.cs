using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;

namespace ModelGen;

public static class TypeInspector
{
  internal static IElementMetadata? InspectType(TypeInfo typeInfo)
  {
    var type = typeInfo.Type;
    if (type != null)
    {
      if (!type.IsAbstract && !type.ContainsGenericParameters)
      {
        var element = type.GetConstructor(new Type[0])?.Invoke(new object[0]) as OpenXmlElement;
        if (element != null)
        {
          var elementMetadata = new ElementMetadataFactoryFeature().GetMetadata(element);
          var particle = elementMetadata.Particle?.Particle;
          if (particle != null) InspectParticle(typeInfo, particle);
          return elementMetadata;
        }
      }
    }
    return null;
  }

  internal static void InspectParticle(TypeInfo typeInfo, ParticleConstraint particle)
  {
    var isMultiple = particle.CanOccursMoreThanOne;
    if (particle is CompositeParticle compositeParticle)
    {
      foreach (var childParticle in compositeParticle.ChildrenParticles)
        InspectParticle(typeInfo, childParticle);
    }
    else 
    if (particle is ElementParticle elementParticle)
    {
      var elementType = elementParticle.ElementType;
      var itemTypeInfo = TypeManager.RegisterType(elementType);
      var itemTypeRelation = typeInfo.AddRelationship(itemTypeInfo, Semantics.Include);
      itemTypeRelation.IsMultiple = isMultiple;
    }
  }
}