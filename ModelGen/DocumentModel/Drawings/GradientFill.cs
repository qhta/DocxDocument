namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill
{
  
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
