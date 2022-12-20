namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Shape Extent.
/// </summary>
public partial interface Extent
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx { get; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy { get; set; }
  
}
