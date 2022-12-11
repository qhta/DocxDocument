using System.Diagnostics;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;

namespace ModelGen;

public static class TypeInspector
{
  internal static IElementMetadata? InspectType(this TypeInfo typeInfo)
  {
    if (typeInfo.Metadata != null)
      return typeInfo.Metadata;
    var type = typeInfo.Type;
    if (type != null)
    {
      if (!type.IsAbstract && !type.ContainsGenericParameters)
      {
        var element = type.GetConstructor(new Type[0])?.Invoke(new object[0]) as OpenXmlElement;
        if (element != null)
        {
          var elementMetadata = new ElementMetadataFactoryFeature().GetMetadata(element);
          typeInfo.Metadata = elementMetadata;
          var particle = elementMetadata.Particle?.Particle;
          if (particle != null) 
            typeInfo.ItemsConstraint = InspectParticle(typeInfo, particle, false);
          return elementMetadata;
        }
      }
    }
    return null;
  }

  internal static ItemsConstraint? InspectParticle(TypeInfo typeInfo, ParticleConstraint particle, bool multiple)
  {
    //if (typeInfo.Name=="Rsids")
    //  Debug.Assert(true);
    var isMultiple = multiple || particle.CanOccursMoreThanOne;
    ItemsConstraint? itemsConstraint = null;
    if (particle is CompositeParticle compositeParticle)
    {
      itemsConstraint = new ItemsCompoundConstraint
      {
        ConstraintType = (ConstraintType)particle.ParticleType,
        IsRequired = particle.MinOccurs > 0,
        IsMultiple = (particle.MinOccurs == 0 && particle.MaxOccurs == 0),
      };
      foreach (var childParticle in compositeParticle.ChildrenParticles)
      {
        var itemConstraint = InspectParticle(typeInfo, childParticle, isMultiple);
        if (itemConstraint!=null)
          ((ItemsCompoundConstraint)itemsConstraint).Items.Add(itemConstraint);
      }
    }
    else 
    if (particle is ElementParticle elementParticle)
    {
      itemsConstraint = new ItemTypeConstraint
      {
        ConstraintType = (ConstraintType)particle.ParticleType,
        IsRequired = particle.MinOccurs > 0,
        IsMultiple = (particle.MinOccurs == 0 && particle.MaxOccurs == 0),
      };
      var elementType = elementParticle.ElementType;
      var itemTypeInfo = TypeManager.RegisterType(elementType);
      itemTypeInfo.IsAccepted = true;
      var itemTypeRelation = typeInfo.AddRelationship(itemTypeInfo, Semantics.Include);
      itemTypeRelation.IsMultiple = isMultiple;
      ((ItemTypeConstraint)itemsConstraint).ItemType = itemTypeInfo;
    }
    return itemsConstraint;
  }
}