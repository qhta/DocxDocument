namespace DocumentModel;
/// <summary>
///   Heading Pairs.
/// </summary>
[SimpleType]
[OpenXmlType(typeof(HeadingPair))]
public class HeadingPairs : ValueCollection<HeadingPair>, IEquatable<HeadingPairs>
{
 public override bool Equals(object? obj)
 {
  if (obj is HeadingPairs other)
   return Equals(other);
  return false;
 }

 public override int GetHashCode()
 {
  return base.GetHashCode();
 }

 public bool Equals(HeadingPairs? other)
 {
  if (other == null)
   return false;
  return this.SequenceEqual(other);
 }
}