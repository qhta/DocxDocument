namespace DocumentModel;

internal abstract class Particle<T>
{
  /// <summary>Gets the minOccurs constraint.</summary>
  public int MinOccurs { get; }
  /// <summary>
  ///   Gets the maxOccurs constraint.
  ///   0 means "unbounded".
  /// </summary>
  public int MaxOccurs { get; }
  /// <summary>
  ///   Gets a value indicating whether the maxOccurs is unbounded.
  /// </summary>
  internal bool UnboundedMaxOccurs => MaxOccurs == 0;
  /// <summary>
  ///   Gets a value indicating whether maxOccurs is unbounded or maxOccurs &gt; 1
  /// </summary>
  internal bool CanOccursMoreThanOne => UnboundedMaxOccurs || MaxOccurs > 1;
  /// <summary>Test whether the count is valid.</summary>
  /// <param name="count">The count of the occurs.</param>
  /// <returns>Returns true if maxOccurs="unbounded" or this.MaxOccurs&gt;count.</returns>
  internal bool MaxOccursGreaterThan(int count)
  {
    return UnboundedMaxOccurs || MaxOccurs > count;
  }
}