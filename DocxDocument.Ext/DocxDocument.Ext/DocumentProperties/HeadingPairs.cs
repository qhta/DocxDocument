namespace DocumentModel;

/// <summary>
///   Heading Pairs.
/// </summary>
public class HeadingPairs : Collection<HeadingPair>, IEquatable<HeadingPairs>
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