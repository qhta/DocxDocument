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
  public DMD.GradientStopList? GradientStopList { get; set; }
  
  public DMD.LinearGradientFill? LinearGradientFill { get; set; }
  
  public DMD.PathGradientFill? PathGradientFill { get; set; }
  
  public DMD.TileRectangle? TileRectangle { get; set; }
  
}
