namespace DocumentModel;

/// <summary>
/// This class represents a collection stored in a HeadingPair extended document property.
/// Although in OpenXml this property is of Variant type, it must be converted to this class to enable proper serialization.
/// </summary>
public class HeadingPairs : Collection<HeadingPair>, IEquatable<HeadingPairs>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  public override bool Equals(object? obj)
  {
    if (obj is HeadingPairs other) return Equals(other); return false;
  }

  public override int GetHashCode()
  {
    return base.GetHashCode();
  }

  public bool Equals(HeadingPairs? other)
  {
    if (other == null)
      return false;
    return Enumerable.SequenceEqual(this, other);
  }
}