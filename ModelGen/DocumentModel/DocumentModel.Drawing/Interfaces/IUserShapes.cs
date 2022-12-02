namespace DocumentModel.Drawing;

/// <summary>
/// User Shapes.
/// </summary>
public interface IUserShapes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public DocumentModel.Drawing.IRelativeAnchorSize? RelativeAnchorSize { get ; set; }
  
  public DocumentModel.Drawing.IAbsoluteAnchorSize? AbsoluteAnchorSize { get ; set; }
  
}
