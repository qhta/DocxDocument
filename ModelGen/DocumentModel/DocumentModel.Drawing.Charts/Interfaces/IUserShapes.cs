namespace DocumentModel.Drawing.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public interface IUserShapes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Drawing.ChartDrawing.IRelativeAnchorSize? RelativeAnchorSize { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.IAbsoluteAnchorSize? AbsoluteAnchorSize { get ; set; }
  
}
