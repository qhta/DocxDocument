namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public partial interface GroupShape
{
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.GroupShapeProperties? GroupShapeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.WordprocessingShape? WordprocessingShape { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.GroupShape? ChildGroupShape { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.GraphicFrame? GraphicFrame { get; set; }
  
  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }
  
  public DocumentModel.Wordprocessing.ContentPart2? ContentPart { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingGroup.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
