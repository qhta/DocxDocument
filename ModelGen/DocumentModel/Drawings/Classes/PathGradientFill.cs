namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class PathGradientFill
{
  
  /// <summary>
  ///   Specifies the shape of the path to follow.
  /// </summary>
  [SchemaAttr("path")]
  public DocumentModel.Drawings.PathShadeValues? Path { get; set; }
  
  
  /// <summary>
  ///   Fill To Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? FillToRectangle { get; set; }
  
}
