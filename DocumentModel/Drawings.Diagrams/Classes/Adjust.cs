namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Adjust.
/// </summary>
public class Adjust: ModelElement
{
  /// <summary>
  ///   Adjust Handle IIndex
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   Value
  /// </summary>
  public Double? Val { get; set; }
}
