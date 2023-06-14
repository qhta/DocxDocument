using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DXFwork = DocumentFormat.OpenXml.Framework;
using DXMeta = DocumentFormat.OpenXml.Framework.Metadata;
using DXSchema = DocumentFormat.OpenXml.Validation.Schema;

using Qhta.TextUtils;
using System.Reflection;

namespace ModelGen;

/// <summary>
/// <para>
///   This class gets the OpenXml element declaration from the source library and reflects its declaration metadata
///   which represents the OpenXml schema structure of the element. 
/// </para>
/// <para>
///   The main metadata element <see cref="DXMeta.ElementMetadata"/> is declared in <see cref="DocumentFormat.OpenXml.Framework.Metadata"/> namespace.
///   The main part of this element is a <see cref="DXFwork.CompiledParticle"/> class declared in <see cref="DocumentFormat.OpenXml.Framework"/> namespace.
///   <see cref="DXFwork.CompiledParticle"/> is a wrapper for schema elements represented by a <see cref="DXSchema.ParticleConstraint"/> class declared in <see cref="DocumentFormat.OpenXml.Validation.Schema"/> namespace.
///   <see cref="DXSchema.ParticleConstraint"/> describes the type of schema element, min and max occurences of this element and the office file version where it can occur.
///   <see cref="DXSchema.ParticleConstraint"/> is an abstract class, which can be an <see cref="DXSchema.ElementParticle"/> or a <see cref="DXSchema.CompositeParticle"/>.
///   <see cref="DXSchema.ElementParticle"/> represents that the declaration of OpenXmlElement type which can occur in the parent particle.
///   <see cref="DXSchema.CompositeParticle"/> represents a group, a sequence, or a choice of embedded particles.
///  </para>
///  <para>
///   The result of <see cref="DXFwork.CompiledParticle"/> conversion is a tree of particle classes:
///   <list type="bullet">
///     <item>
///       <term><see cref="ItemElementParticle"/></term>
///       <description>that represents possible item declaration</description>
///     </item>
///     <item>
///       <term><see cref="ItemsGroupParticle"/></term>
///       <description>that represents possible item group declaration</description>
///     </item>
///     <item>
///       <term><see cref="ItemsSequenceParticle"/></term>
///       <description>that represents possible item sequence declaration</description>
///     </item>
///     <item>
///       <term><see cref="ItemsChoiceParticle"/></term>
///       <description>that represents possible item sequence declaration</description>
///     </item>
///     <item>
///       <term><see cref="ItemsAllParticle"/></term>
///       <description>that represents all required item sequence declaration</description>
///     </item>
///   </list>
///   <see cref="ItemsGroupParticle"/>, <see cref="ItemsSequenceParticle"/>, <see cref="ItemsChoiceParticle"/>, and <see cref="ItemsAllParticle"/>
///   are all subclasses of an abstract <see cref="ItemsParticle"/> class.
/// </para>
/// <para>
///   Other important metadata element is a collection of <see cref="DXMeta.AttributeMetadata">.
///   Each <see cref="DXMeta.AttributeMetadata"/> has an array of <see cref="DXFwork.IValidator"/> interface implementing classes.
///   Recognized validator classes are: <see cref="DXFwork.StringValidator"/>, <see cref="DXFwork.NumberValidator"/>, 
///   <see cref="DXFwork.RequiredValidator"/>, <see cref="DXFwork.EnumValidator"/>, <see cref="DXFwork.ListValidator"/>,
///   <see cref="DXFwork.UnionValidator"/>, <see cref="DXFwork.SimpleTypeValidator{TSimpleType}"/>, 
///   <see cref="DXFwork.NameProviderValidator"/>, and <see cref="DXFwork.OfficeVersionValidator"/>.
///   First two validators are converted to <see cref="Constraint"/> classes:
///   <list type="bullet">
///     <item>
///       <term><see cref="StringConstraint"/></term>
///       <description>which can hold MinLength, MaxLength, and Length attributes of the string property</description>
///     </item>
///     <item>
///       <term><see cref="NumberConstraint"/></term>
///       <description>which can hold MinInclusive, MaxInclusive, MinExclusive, and MaxExclusive long integer values of the property</description>
///     </item>
///   </list>
///   Three subsequent validators set some flags of the <see cref="PropInfo"/>:
///   <list type="bullet">
///     <item>
///       <term><see cref="PropInfo.IsRequired"/></term>
///       <description>- a property is required</description>
///     </item>
///     <item>
///       <term><see cref="PropInfo.IsEnum"/></term>
///       <description>- a property is of enum type</description>
///     </item>
///     <item>
///       <term><see cref="PropInfo.IsList"/></term>
///       <description>- a property is of list type</description>
///     </item>
///   </list>
///   <see cref="DXFwork.UnionValidator"/> contains some internal validators, which are converted as other ones.
///   <see cref="DXFwork.SimpleTypeValidator{TSimpleType}"/> is converted as <see cref="DXFwork.EnumValidator"/> 
///   (only <see cref="DX.EnumValue{T}"/> appears).
///   <see cref="DXFwork.NameProviderValidator"/> is converted to <see cref="PropInfo.RealTypeName"/> attribute, 
///   and <see cref="DXFwork.OfficeVersionValidator"/> is ignored.
/// </para>
/// </summary>
public static class OpenXmlMetadataReader
{

  /// <summary>
  /// Reads typeInfo.Type OpenXml <see cref="DXMeta.ElementMetadata"/> object using <see cref="DXMeta.ElementMetadataFactoryFeature"/>.
  /// Creates <see cref="ElementSchema"/> basing on OpenXml <see cref="DXMeta.ElementMetadata.Particle"/> property.
  /// If <see cref="DXMeta.ElementMetadata"/> has attributes, then sets <see cref="PropInfo.Constraints"> collection.
  /// </summary>
  /// <param name="typeInfo">TypeInfo for which the element metadata is processed.</param>
  /// <returns>Created element schema</returns>
  public static ElementSchema? GetElementSchema(this TypeInfo typeInfo)
  {
    ElementSchema? elementSchema = null;
    var type = typeInfo.Type;
    if (type != null)
    {
      if (!type.IsAbstract && !type.ContainsGenericParameters)
      {
        var element = type.GetConstructor(new Type[0])?.Invoke(new object[0]) as OpenXmlElement;
        if (element != null)
        {
          var elementMetadata = new DXMeta.ElementMetadataFactoryFeature().GetMetadata(element);
          var metadataParticle = elementMetadata.Particle?.Particle;
          if (metadataParticle != null)
          {
            var schemaParticle = GetSchemaParticle(typeInfo, metadataParticle, false);
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
                  CreateConstraints(propInfo, attrib.Validators);
                }
              }
            }
          }
        }
      }
    }
    return elementSchema;
  }

  #region CompiledParticle read methods

  /// <summary>
  /// Gets a <see cref="DXSchema.ParticleConstraint"/> and converts it to a <see cref="SchemaParticle"/>.
  /// Uses specific methods: <see cref="CreateElementParticle"/> and <see cref="CreateItemsParticle"/>.
  /// </summary>
  /// <param name="ownerTypeInfo">TypeInfo for which medatada is analyzed.</param>
  /// <param name="particle">ParticleConstraint from metadata.</param>
  /// <param name="multiple">specifies whether many particles can appear.</param>
  /// <returns>Created schema particle</returns>
  internal static SchemaParticle? GetSchemaParticle(TypeInfo ownerTypeInfo, DXSchema.ParticleConstraint particle, bool multiple)
  {
    var isMultiple = multiple || particle.CanOccursMoreThanOne;
    SchemaParticle? schemaParticle = null;
    if (particle is DXSchema.CompositeParticle compositeParticle)
      schemaParticle = CreateItemsParticle(ownerTypeInfo, compositeParticle, isMultiple);
    else
    if (particle is DXSchema.ElementParticle elementParticle)
      schemaParticle = CreateElementParticle(ownerTypeInfo, elementParticle, isMultiple);
    return schemaParticle;
  }

  /// <summary>
  /// Creates <see cref="ItemElementParticle"/> basing on OpenXml <see cref="DXFwork.ElementParticle"/>.
  /// Creates elementTypeInfo by registering elementType.
  /// Adds "include" relationship between owner type info with possible isMultiple flag.
  /// Sets the name of the result particle basing on element schemaTag or element type name
  /// </summary>
  /// <param name="ownerTypeInfo">Type info for which the particle is processed</param>
  /// <param name="elementParticle">Processed OpenXml element particle</param>
  /// <param name="isMultiple">specifies whether many particles can appear.</param>
  /// <returns>Created schema element particle</returns>
  private static ItemElementParticle CreateElementParticle(TypeInfo ownerTypeInfo, DXSchema.ElementParticle elementParticle, bool isMultiple)
  {
    var schemaParticle = new ItemElementParticle
    {
      IsRequired = elementParticle.MinOccurs > 0,
      IsMultiple = (elementParticle.MinOccurs == 0 && elementParticle.MaxOccurs == 0) || elementParticle.MaxOccurs > 1,
      MinOccurs = (elementParticle.MinOccurs > 0) ? elementParticle.MinOccurs : null,
      MaxOccurs = (elementParticle.MaxOccurs > 0) ? elementParticle.MaxOccurs : null,
    };
    var elementType = elementParticle.ElementType;
    var elementTypeInfo = TypeManager.RegisterType(elementType);
    if (elementTypeInfo != null)
    {
      var itemTypeRelation = ownerTypeInfo.AddRelationship(elementTypeInfo, Semantics.Include);
      itemTypeRelation.IsMultiple = isMultiple;
      schemaParticle.ItemType = elementTypeInfo;
    }
    var name = schemaParticle.ItemType.Metadata?.SchemaTag ?? schemaParticle.ItemType.Name;
    schemaParticle.Name = name;
    return schemaParticle;
  }

  /// <summary>
  /// Creates <see cref="SchemaParticle"/> basing on OpenXml <see cref="DXFwork.CompositeParticle"/>.
  /// Sets name of the created particle basing on <see cref="ModelData"/> class.
  /// </summary>
  /// <param name="ownerTypeInfo">Type info for which the particle is processed</param>
  /// <param name="compositeParticle">Processed OpenXml composite particle</param>
  /// <param name="isMultiple">specifies whether many particles can appear.</param>
  /// <returns>Created schema items particle</returns>
  private static SchemaParticle CreateItemsParticle(TypeInfo ownerTypeInfo, DXSchema.CompositeParticle compositeParticle, bool isMultiple)
  {
    var schemaParticle = ItemsParticle.Create((ParticleType)compositeParticle.ParticleType);
    schemaParticle.IsRequired = compositeParticle.MinOccurs > 0;
    schemaParticle.IsMultiple = (compositeParticle.MinOccurs == 0 && compositeParticle.MaxOccurs == 0) || compositeParticle.MaxOccurs > 1;
    schemaParticle.MinOccurs = (compositeParticle.MinOccurs > 0) ? compositeParticle.MinOccurs : null;
    schemaParticle.MaxOccurs = (compositeParticle.MaxOccurs > 0) ? compositeParticle.MaxOccurs : null;
    foreach (var childParticle in compositeParticle.ChildrenParticles)
    {
      var itemParticle = GetSchemaParticle(ownerTypeInfo, childParticle, isMultiple);
      if (itemParticle != null)
        schemaParticle.Items.Add(itemParticle);
    }
    if (schemaParticle.ParticleType == ParticleType.Choice)
      SetItemsParticleName(schemaParticle);
    else
    if (schemaParticle.ParticleType == ParticleType.Sequence)
      SetItemsParticleName(schemaParticle);
    else
    if (schemaParticle.ParticleType == ParticleType.Group)
      SetGroupParticleName(schemaParticle);
    return schemaParticle;
  }

  /// <summary>
  /// Sets the name of the group particle. This particle should contain only one item element, 
  /// which name is returned.
  /// </summary>
  /// <param name="groupParticle">Group particle to name.</param>
  /// <returns>Name of the first item.</returns>
  /// <exception cref="System.InvalidOperationException">Thrown when group particle have more or less than one item.</exception>
  private static string? SetGroupParticleName(ItemsParticle groupParticle)
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
        return subParticle.Name;
      }
      else
      {
        groupParticle.Name = subParticle.Name;
        return groupParticle.Name;
      }
    }
    throw new System.InvalidOperationException($"Group particle can have only one item");
  }

  /// <summary>
  /// Sets the name of the item particle. Scans all item particle names and asks <see cref="ModelData"/> for a common type name.
  /// </summary>
  /// <param name="itemsParticle">Items particle to name</param>
  /// <returns>Common type name or items names joined with '|'.</returns>
  private static string SetItemsParticleName(ItemsParticle itemsParticle)
  {
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
          itemName = SetItemsParticleName(itemParticle);
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

  /// <summary>
  /// Takes a source list of names and produces a target list of names.
  /// The target list should contain less items than the source one.
  /// </summary>
  /// <param name="sourceNames">List of source type names.</param>
  /// <param name="targetNames">List of target type names.</param>
  /// <returns>true if a target list contains less items than the source one.</returns>
  private static bool TryReduceItemNames(List<string> sourceNames, out List<string> targetNames)
  {
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

  /// <summary>
  /// Method to get a common key to group names.
  /// </summary>
  /// <param name="name">Item name.</param>
  /// <returns>Common type name or the source name.</returns>
  private static string GetKey(string name)
  {
    if (TryGetCommonTypeName(name, out var newName))
      return newName;
    else
      return name;
  }

  /// <summary>
  /// Method to get a common type name from <see cref="ModelData"/> component.
  /// </summary>
  /// <param name="name">Item name.</param>
  /// <param name="newName">Common type name or null.</param>
  /// <returns>True if could get common type name</returns>
  private static bool TryGetCommonTypeName(string name, [NotNullWhen(true)] out string? newName)
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
  #endregion

  #region Attribute Validators read methods

  /// <summary>
  /// Converts schema property validators to <see cref="PropInfo"/> constraints or <see cref="PropInfo"/> flags.
  /// </summary>
  /// <param name="propInfo">Owner propInfo of the validators.</param>
  /// <param name="validators">Validators collection</param>
  /// <exception cref="System.InvalidOperationException">Raised when unexpected data is found.</exception>
  private static void CreateConstraints(PropInfo propInfo, IEnumerable<DXFwork.IValidator> validators)
  {
    foreach (var validator in validators)
    {
      if (validator is DXFwork.StringValidator stringValidator)
      {
        if (propInfo.Constraints == null)
          propInfo.Constraints = new Constraints();
        propInfo.Constraints.Add(new StringConstraint
        {
          Length = stringValidator.Length,
          MinLength = stringValidator.MinLength,
          MaxLength = stringValidator.MaxLength
        });
        propInfo.IsConstrained = true;
      }
      else
      if (validator is DXFwork.RequiredValidator requiredValidator)
      {
        propInfo.IsRequired = requiredValidator.IsRequired;
      }
      else
      if (validator is DXFwork.NumberValidator numberValidator)
      {
        if (propInfo.Constraints == null)
          propInfo.Constraints = new Constraints();
        propInfo.Constraints.Add(new NumberConstraint
        {
          MinExclusive = numberValidator.MinExclusive,
          MaxExclusive = numberValidator.MaxExclusive,
          MinInclusive = numberValidator.MinInclusive,
          MaxInclusive = numberValidator.MaxInclusive,
        });
        propInfo.IsConstrained = true;
      }
      else
      if (validator is DXFwork.EnumValidator)
      {
        //if (!propInfo.PropertyType.Type.IsEnum && !propInfo.PropertyType.Type.Name.StartsWith("EnumValue`"))
        //  throw new System.InvalidOperationException($"Property {propInfo.DeclaringType?.Name}.{propInfo.Name} must be of enum type");
        propInfo.IsEnum = true;
      }
      else
      if (validator is DXFwork.UnionValidator unionValidator)
      {
        CreateConstraints(propInfo, unionValidator.Validators);
      }
      else
      if (validator.GetType().Name.StartsWith("SimpleTypeValidator`"))
      {
        var argType = validator.GetType().GetGenericArguments().First();
        if (argType.Name.StartsWith("EnumValue`"))
          propInfo.IsEnum = true;
        else
          throw new System.InvalidOperationException($"Unexpected simple type name \"{argType.Name}\"");
        //CreateConstraints(propInfo, unionValidator.Validators);
      }
      else
      if (validator is DXFwork.OfficeVersionValidator)
      {
        //ignore
      }
      else
      if (validator is DXFwork.NameProviderValidator nameProviderValidator)
      {
        propInfo.RealTypeName = nameProviderValidator.QName.ToString();
        //if (Assembly.Load("System").GetType(propInfo.RealTypeName)==null)
        if (!KnownRealTypes.Contains(propInfo.RealTypeName))
          throw new System.InvalidOperationException($"Unknown real type name \"{propInfo.RealTypeName}\"");
      }
      else
      if (validator is DXFwork.ListValidator listValidator)
      {
        propInfo.IsList = true;
      }
      else
      {
        throw new System.InvalidOperationException($"Unrecognized validator type {validator.GetType()}");
      }
    }
  }

  public static string[] KnownRealTypes = new string[] 
  {
    "Int64","Int32","UInt32","Double","Boolean",
    "http://www.w3.org/2001/XMLSchema:hexBinary",
    "http://www.w3.org/2001/XMLSchema:integer",
  };
  #endregion
}