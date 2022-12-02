namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Paths.
/// </summary>
public interface IPathList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPath>? Paths { get ; set; }
  
}
