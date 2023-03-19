namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Adjust.
/// </summary>
public class Adjust: ModelElement
{
  /// <summary>
  ///   Adjust Handle Index
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
}