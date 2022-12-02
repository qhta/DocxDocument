namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface IShapeTree // : DocumentModel.Drawing.IGroupShapeType
{
  public DocumentModel.Drawing.IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
