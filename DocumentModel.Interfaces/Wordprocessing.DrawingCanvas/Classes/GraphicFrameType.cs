using DocumentModel.Drawings;
using DocumentModel.Wordprocessing.DrawingGroup;
namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the GraphicFrameType Class.
/// </summary>
public class GraphicFrameType: ModelElement
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  /// <summary>
  ///   NonVisualGraphicFrameProperties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
  /// <summary>
  ///   Transform2D.
  /// </summary>
  public DrawingGroup.Transform2D? Transform2D { get; set; }
  /// <summary>
  ///   Graphic.
  /// </summary>
  public Graphic? Graphic { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DrawingGroup.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}