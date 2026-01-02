using DocumentModel.Wordprocessing.DrawingShape;
namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public class GroupShape: ModelElement
{
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
  public GroupShapeProperties? GroupShapeProperties { get; set; }
  public WordprocessingShape? WordprocessingShape { get; set; }
  public GroupShape? ChildGroupShape { get; set; }
  public GraphicFrame? GraphicFrame { get; set; }
  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}