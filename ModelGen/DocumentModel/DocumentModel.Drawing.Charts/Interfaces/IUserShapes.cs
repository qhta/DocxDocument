namespace DocumentModel.Drawing.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public interface IUserShapes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the ChartDrawingPart associated with this element.
  /// </summary>
  public ChartDrawingPart? ChartDrawingPart { get ; set; }
  
}
