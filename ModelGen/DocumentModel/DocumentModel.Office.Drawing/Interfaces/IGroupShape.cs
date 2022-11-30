namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public interface IGroupShape // : DocumentModel.Office.Drawing.IGroupShapeType
{
  public DocumentModel.Office.Drawing.IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  public DocumentModel.Office.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Office.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Office.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Office.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
