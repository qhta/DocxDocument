using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the GraphicFrame Class.
/// </summary>
public class GraphicFrame
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   NonVisualGraphicFrameProperties.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }

  /// <summary>
  ///   Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   Graphic.
  /// </summary>
  public Graphic? Graphic { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}