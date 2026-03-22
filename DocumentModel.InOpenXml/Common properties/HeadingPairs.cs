namespace DocumentModel;
/// <summary>
///   Represents a collection of heading pair values, typically used for document property metadata.
/// </summary>
[SimpleType]
[OpenXmlType(typeof(HeadingPair))]
public class HeadingPairs : ModelElementCollection<HeadingPair>, IEquatable<HeadingPairs>
{
  /// <summary>
  /// Default constructor. Needed to allow adding items.
  /// </summary>
  public HeadingPairs()
  {
  }
  /// <summary>
 ///   Determines whether the specified object is equal to the current HeadingPairs collection.
 /// </summary>
 /// <param name="obj">The object to compare with the current collection.</param>
 /// <returns>True if the specified object is a HeadingPairs collection with the same sequence of values; otherwise, false.</returns>
 public override bool Equals(object? obj)
 {
  if (obj is HeadingPairs other)
   return Equals(other);
  return false;
 }
 /// <summary>
 ///   Determines whether the specified HeadingPairs collection is equal to the current collection.
 /// </summary>
 /// <param name="other">The HeadingPairs collection to compare with the current collection.</param>
 /// <returns>True if the collections contain the same sequence of values; otherwise, false.</returns>
 public bool Equals(HeadingPairs? other)
 {
  if (other == null)
   return false;
  return this.SequenceEqual(other);
 }
}