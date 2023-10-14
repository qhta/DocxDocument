namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class PathGradientFill
{
  
  /// <summary>
  ///   Specifies the shape of the path to follow.
  /// </summary>
  public DocumentModel.Drawings.PathShadeKind? Path { get; set; }
  
  
  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawings.FillToRectangle? FillToRectangle { get; set; }
  
}
