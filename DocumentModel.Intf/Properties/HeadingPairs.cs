

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Heading Pairs.
/// </summary>
public class HeadingPairs : ValueCollection<StringNum>, IEquatable<HeadingPairs>
{
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