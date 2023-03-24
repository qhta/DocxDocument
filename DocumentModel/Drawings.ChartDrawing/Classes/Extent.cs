namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Extent.
/// </summary>
public class Extent: ModelElement
{
  /// <summary>
  ///   Extent Length
  /// </summary>
  public Int64? Cx { get; set; }

  /// <summary>
  ///   Extent Width
  /// </summary>
  public Int64? Cy { get; set; }
}