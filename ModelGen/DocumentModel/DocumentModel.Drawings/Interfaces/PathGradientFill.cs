namespace DocumentModel.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public interface PathGradientFill
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public Boolean? FillToRectangle { get ; set; }
  
}
