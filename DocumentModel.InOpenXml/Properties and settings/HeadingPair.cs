namespace DocumentModel;
/// <summary>
///   Represents a heading pair, indicating the conceptual grouping of document sections and the number of parts in each group.
///   Used in document property metadata to describe logical document structure for navigation and summary purposes.
/// </summary>
public readonly struct HeadingPair : IEquatable<HeadingPair>
{
  /// <summary>
  ///   The name or label of the heading group (e.g., "Chapter", "Section").
  /// </summary>
  public string? Name { get; init; }

  /// <summary>
  ///   The number of parts or sections associated with the heading group.
  /// </summary>
  public int? Number { get; init; }

  /// <summary>
  ///   Determines whether the specified <see cref="HeadingPair"/> is equal to the current instance.
  /// </summary>
  /// <param name="other">The <see cref="HeadingPair"/> to compare with the current instance.</param>
  /// <returns>True if the name and number are equal; otherwise, false.</returns>
  public bool Equals(HeadingPair other)
  {
    return Name == other.Name && Number == other.Number;
  }

  /// <summary>
  ///   Determines whether the specified object is equal to the current <see cref="HeadingPair"/> instance.
  /// </summary>
  /// <param name="obj">The object to compare with the current instance.</param>
  /// <returns>True if the object is a <see cref="HeadingPair"/> with the same values; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    if (obj is null) return false;
    if (obj.GetType() != GetType()) return false;
    return Equals((HeadingPair)obj);
  }

  /// <summary>
  ///   Returns a hash code for the current <see cref="HeadingPair"/> instance.
  /// </summary>
  /// <returns>A hash code based on the name and number values.</returns>
  public override int GetHashCode()
  {
    return HashCode.Combine(Name, Number);
  }
}
