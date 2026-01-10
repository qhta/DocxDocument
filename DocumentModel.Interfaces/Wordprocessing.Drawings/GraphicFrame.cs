using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Represents a graphic frame element within a Wordprocessing document drawing group.
/// This interface provides access to non-visual properties, transformation settings, and the contained graphic, enabling advanced layout and rendering of graphical content.
/// </summary>
public interface GraphicFrame : OfficeArtExtendableElement
{
  /// <summary>
  /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  /// <summary>
  /// Non-visual properties specific to the graphic frame, such as locking and extension settings.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }
  /// <summary>
  /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew.
  /// </summary>
  public Transform2D? Transform2D { get; set; }
  /// <summary>
  /// The graphic content contained within the frame, such as images, charts, or diagrams.
  /// </summary>
  public Graphic? Graphic { get; set; }
}