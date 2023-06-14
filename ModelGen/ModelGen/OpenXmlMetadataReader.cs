using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Validation.Schema;

using Qhta.TextUtils;

namespace ModelGen;

/// <summary>
/// <para>
///   This class gets the OpenXml element declaration from the source library and reflects its declaration metadata
///   which represents the OpenXml schema structure of the element. 
/// </para>
/// <para>
///   Tme main metadata interface <see cref="IElementMetadata"/> is declared in <see cref="DocumentFormat.OpenXml.Framework.Metadata"/> namespace.
///   The main part of this interface is a <see cref="CompiledParticle"/> class declared in <see cref="DocumentFormat.OpenXml.Framework"/> namespace.
///   <see cref="CompiledParticle"/> is a wrapper for schema elements represented by a <see cref="ParticleConstraint"/> class declared in <see cref="DocumentFormat.OpenXml.Validation.Schema"/> namespace.
///   <see cref="ParticleConstraint"/> describes the type of schema element, min and max occurences of this element and the office file version where it can occur.
///   <see cref="ParticleConstraint"/> is an abstract class, which can be an <see cref="ElementParticle"/> or a <see cref="CompositeParticle"/>.
///   <see cref="ElementParticle"/> represents that the declaration of OpenXmlElement type which can occur in the parent particle.
///   <see cref="CompositeParticle"/> represents a group, a sequence or a choice of embedded particles.
/// </para>
/// </summary>
public static class OpenXmlMetadataReader
{
  internal static ElementSchema? InspectType(this TypeInfo typeInfo)
  {
    //if (typeInfo.Name == "FontSignature")
    //  Debug.Assert(true);
    ElementSchema? elementSchema = null;
    var type = typeInfo.Type;
    if (type != null)
    {
      if (!type.IsAbstract && !type.ContainsGenericParameters)
      {
        var element = type.GetConstructor(new Type[0])?.Invoke(new object[0]) as OpenXmlElement;
        if (element != null)
        {
          var elementMetadata = new ElementMetadataFactoryFeature().GetMetadata(element);
          var metadataParticle = elementMetadata.Particle?.Particle;
          if (metadataParticle != null)
          {
            var schemaParticle = InspectParticle(typeInfo, metadataParticle, false);
            if (schemaParticle != null)
              elementSchema = new ElementSchema(schemaParticle);
          }
          if (elementMetadata.Attributes.Length > 0)
          {
            foreach (var attrib in elementMetadata.Attributes)
            {
              if (attrib.Validators.Any())
              {
                var propInfo = typeInfo.Properties?.FirstOrDefault(prop => prop.Name == attrib.PropertyName);
                if (propInfo != null)
                {
                  propInfo.Validators = new Validators(attrib.Validators);
                }
              }
            }
          }
        }
      }
    }
    return elementSchema;
  }

  internal static SchemaParticle? InspectParticle(TypeInfo typeInfo, ParticleConstraint particle, bool multiple)
  {
    //if (typeInfo.Name=="Rsids")
    //  Debug.Assert(true);
    var isMultiple = multiple || particle.CanOccursMoreThanOne;
    SchemaParticle? schemaParticle = null;
    if (particle is CompositeParticle compositeParticle)
    {
      var itemsParticle = ItemsParticle.Create((ParticleType)compositeParticle.ParticleType);
      itemsParticle.IsRequired = particle.MinOccurs > 0;
      itemsParticle.IsMultiple = (particle.MinOccurs == 0 && particle.MaxOccurs == 0) || particle.MaxOccurs > 1;
      itemsParticle.MinOccurs = (particle.MinOccurs > 0) ? particle.MinOccurs : null;
      itemsParticle.MaxOccurs = (particle.MaxOccurs > 0) ? particle.MaxOccurs : null;
      foreach (var childParticle in compositeParticle.ChildrenParticles)
      {
        var itemParticle = InspectParticle(typeInfo, childParticle, isMultiple);
        if (itemParticle != null)
          itemsParticle.Items.Add(itemParticle);
      }
      if (itemsParticle.ParticleType == ParticleType.Choice)
        schemaParticle = ProcessChoiceParticle(itemsParticle);
      else
      if (itemsParticle.ParticleType == ParticleType.Sequence)
        schemaParticle = ProcessSequenceParticle(itemsParticle);
      else
      if (itemsParticle.ParticleType == ParticleType.Group)
        schemaParticle = ProcessGroupParticle(itemsParticle);
      else
        schemaParticle = itemsParticle;
    }
    else
    if (particle is ElementParticle elementParticle)
    {
      var itemParticle = new ItemElementParticle
      {
        IsRequired = particle.MinOccurs > 0,
        IsMultiple = (particle.MinOccurs == 0 && particle.MaxOccurs == 0) || particle.MaxOccurs > 1,
        MinOccurs = (particle.MinOccurs > 0) ? particle.MinOccurs : null,
        MaxOccurs = (particle.MaxOccurs > 0) ? particle.MaxOccurs : null,
      };
      var elementType = elementParticle.ElementType;
      var itemTypeInfo = TypeManager.RegisterType(elementType);
      if (itemTypeInfo != null)
      {
        var itemTypeRelation = typeInfo.AddRelationship(itemTypeInfo, Semantics.Include);
        itemTypeRelation.IsMultiple = isMultiple;
        itemParticle.ItemType = itemTypeInfo;
      }
      schemaParticle = itemParticle;
    }
    return schemaParticle;
  }

  private static SchemaParticle ProcessChoiceParticle(ItemsParticle itemsParticle)
  {
    SetParticleName(itemsParticle);
    return itemsParticle;
  }

  private static SchemaParticle ProcessSequenceParticle(ItemsParticle itemsParticle)
  {
    SetParticleName(itemsParticle);
    return itemsParticle;
  }

  private static string SetParticleName(ItemsParticle itemsParticle)
  {
    //if (itemsParticle.ParticleType == ParticleType.Choice
    //  && itemsParticle.Items.First().Name == "DXW.AnnotationRangeMark")
    //  Debug.Assert(true);

    List<string> itemNames = new List<string>();
    foreach (var item in itemsParticle.Items)
    {
      string? itemName = null;
      if (item is ItemElementParticle itemElementParticle)
      {
        itemName = itemElementParticle.ItemType.GetFullName(true, true);
      }
      else
      if (item is ItemsParticle itemParticle)
      {
        itemName = item.Name;
        if (itemName == null)
          itemName = SetParticleName(itemParticle);
        if (itemName != null)
        {
          if (itemName == "DXW.AnnotationRangeMark")
            Debug.Assert(true);
        }
      }
      if (itemName != null)
      {
        if (!itemNames.Contains(itemName))
          itemNames.Add(itemName);
      }
    }
    while (itemNames.Count > 1)
      if (!TryReduceItemNames(itemNames, out itemNames))
        break;
    var newName = String.Join("|", itemNames);
    if (itemNames.Count > 1)
      if (ModelData.CommonTypeName.TryGetValue(newName, out var commonName))
        newName = commonName;
    itemsParticle.Name = newName;
    return newName;
  }

  private static SchemaParticle ProcessGroupParticle(ItemsParticle groupParticle)
  {
    if (groupParticle.Items.Count == 1)
    {
      var subParticle = groupParticle.Items.First();
      if (groupParticle.IsMultiple == subParticle.IsMultiple
        && subParticle.MinOccurs == subParticle.DefMinOccurs && subParticle.MaxOccurs == subParticle.DefMaxOccurs)
      {
        subParticle.IsRequired = groupParticle.IsRequired;
        subParticle.MinOccurs = groupParticle.MinOccurs;
        subParticle.MaxOccurs = groupParticle.MaxOccurs;
        return subParticle;
      }
      else
      {
        groupParticle.Name = subParticle.Name;
        return groupParticle;
      }
    }
    throw new System.InvalidOperationException($"Group particle can have only one item");
  }

  private static bool TryReduceItemNames(List<string> sourceNames, out List<string> targetNames)
  {
    if (sourceNames.First() == "DXW.AnnotationRangeMark")
      Debug.Assert(true);
    var grouping = sourceNames.GroupBy(name => GetKey(name));
    targetNames = new List<string>();
    foreach (var group in grouping)
    {
      var name = group.Key;
      if (!targetNames.Contains(name))
        targetNames.Add(name);
    }
    return targetNames.Count < sourceNames.Count;
  }

  private static string GetKey(string name)
  {
    if (TryGetSuperTypeName(name, out var newName))
      return newName;
    else
      return name;
  }

  private static bool TryGetSuperTypeName(string name, [NotNullWhen(true)] out string? newName)
  {
    string prefix = string.Empty;
    if (ModelData.TryGetCommonTypeName(name, out newName))
      return true;
    var k = name.LastIndexOf('.');
    if (k > 0)
    {
      prefix = name.Substring(0, k);
      name = name.Substring(k + 1);
    }
    if (ModelData.TryGetCommonTypeName(name, out newName))
    {
      if (prefix != string.Empty)
        newName = prefix + "." + newName;
      return true;
    }
    newName = null;
    return false;
  }

}