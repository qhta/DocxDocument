using System.Runtime.Serialization;

namespace ModelGen;

[KnownType(typeof(ItemElementParticle))]
[KnownType(typeof(ItemsParticle))]
public abstract class SchemaParticle
{
  public ParticleType ParticleType { [DebuggerStepThrough] get; set; }

  public string? Name { [DebuggerStepThrough] get; set; }

  public bool IsOptional => MinOccurs == 0;
  public bool IsMultiple => MaxOccurs == 0 || MaxOccurs > 1;

  public int MinOccurs { [DebuggerStepThrough] get; set; }
  public int MaxOccurs { [DebuggerStepThrough] get; set; }

  public int DefaultMinOccurs 
    => (IsOptional) ? 0 : 1;
  public int DefaultMaxOccurs 
    => (IsMultiple) ? 0 : 1;

  /// <summary>
  /// Returns flattened list of item types from schema.
  /// Items in the list are unique.
  /// </summary>
  /// <param name="schema"></param>
  /// <returns></returns>
  public List<TypeInfo> GetItemTypes()
  {
    var types = new List<TypeInfo>();
    if (this is ItemElementParticle elementParticle)
    {
      if (elementParticle.ItemType != null)
      {
        if (!types.Contains(elementParticle.ItemType))
          types.Add(elementParticle.ItemType);
      }
    }
    else
    if (this is ItemsParticle itemsParticle)
    {
      foreach (var particle in itemsParticle.Items)
      {
        foreach (var itemType in particle.GetItemTypes())
          if (!types.Contains(itemType))
            types.Add(itemType);
      }
    }
    return types;
  }
}