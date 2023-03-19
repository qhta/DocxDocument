using DocumentModel.Wordprocessing.DrawingShape;

namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the WordprocessingGroup Class.
/// </summary>
public class WordprocessingGroup: ModelElement
{
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }

  public GroupShapeProperties? GroupShapeProperties { get; set; }

  public WordprocessingShape? WordprocessingShape { get; set; }

  public GroupShape? GroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}