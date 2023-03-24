namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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