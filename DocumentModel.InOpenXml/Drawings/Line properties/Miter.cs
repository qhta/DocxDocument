namespace DocumentModel.Drawings;

/// <summary>
///   Represents a miter line join, specifying the miter limit for the join.
/// </summary>
public class Miter: ModelElement
{
  /// <summary>
  ///   Miter join limit value.
  /// </summary>
  public Int32? Limit { get; set; }
}