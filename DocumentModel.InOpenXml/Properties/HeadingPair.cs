namespace DocumentModel;
/// <summary>
/// Heading pairs indicates the grouping of document parts and the number of parts in each group.
/// These parts are not document parts but conceptual representations of document sections.
/// </summary>
public readonly struct HeadingPair: IEquatable<HeadingPair>
{
  /// <summary>
  /// String part of the structure.
  /// </summary>
  public string? Name { get; init; }
  /// <summary>
  /// Number part of the structure.
  /// </summary>
  public int? Number { get; init; }

  public bool Equals(HeadingPair other)
  {
    return Name == other.Name && Number == other.Number;
  }

  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (obj.GetType() != GetType()) return false;
    return Equals((HeadingPair)obj);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Name, Number);
  }
}