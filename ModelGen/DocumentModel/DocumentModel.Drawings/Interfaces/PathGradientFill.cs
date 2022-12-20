namespace DocumentModel.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public partial interface PathGradientFill
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public DocumentModel.Drawings.PathShadeKind? Path { get; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? FillToRectangle { get; set; }
  
}
