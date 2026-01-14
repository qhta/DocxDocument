namespace DocumentModel.Drawings;

/// <summary>
///   Represents a miter line join, specifying the miter limit for the join.
/// </summary>
public interface Miter
{
  /// <summary>
  ///   Miter join limit value.
  /// </summary>
  public Int32? Limit { get; set; }
}