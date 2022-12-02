namespace DocumentModel.Drawing;

/// <summary>
/// User Shapes.
/// </summary>
public interface IUserShapes // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IRelativeAnchorSize>? RelativeAnchorSizes { get ; set; }
  
  public Collection<IAbsoluteAnchorSize>? AbsoluteAnchorSizes { get ; set; }
  
}
