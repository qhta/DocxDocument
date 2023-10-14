namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill
{
  
  /// <summary>
  ///   Specifies the direction(s) in which to flip the gradient while tiling.
  /// </summary>
  public DocumentModel.Drawings.TileFlipKind? Flip { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawings.GradientStopList? GradientStopList { get; set; }
  
  public DocumentModel.Drawings.LinearGradientFill? LinearGradientFill { get; set; }
  
  public DocumentModel.Drawings.PathGradientFill? PathGradientFill { get; set; }
  
  public DocumentModel.Drawings.TileRectangle? TileRectangle { get; set; }
  
}
