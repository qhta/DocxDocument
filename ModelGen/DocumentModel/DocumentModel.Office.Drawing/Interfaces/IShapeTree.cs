namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public interface IShapeTree // : DocumentModel.Office.Drawing.IGroupShapeType
{
  public DocumentModel.Office.Drawing.IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Office.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Office.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Office.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Office.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
