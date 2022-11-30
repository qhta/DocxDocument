namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Paths.
/// </summary>
public interface IPathList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPath>? Paths { get ; set; }
  
}
