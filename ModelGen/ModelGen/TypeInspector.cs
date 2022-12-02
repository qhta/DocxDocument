using System.Diagnostics;

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
          if (typeInfo.Type == typeof(DocumentFormat.OpenXml.Wordprocessing.Body))
            Debug.Assert(true);
          var particle = elementMetadata.Particle?.Particle;
          if (particle != null) InspectParticle(typeInfo, particle, false);
          return elementMetadata;
        }
      }
    }
    return null;
  }

  internal static void InspectParticle(TypeInfo typeInfo, ParticleConstraint particle, bool multiple)
  {
    var isMultiple = multiple || particle.CanOccursMoreThanOne;
    if (particle is CompositeParticle compositeParticle)
    {
      foreach (var childParticle in compositeParticle.ChildrenParticles)
        InspectParticle(typeInfo, childParticle, isMultiple);
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