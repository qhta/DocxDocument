using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a graphic frame element in a Wordprocessing document.
/// This interface provides access to non-visual properties, transformation settings, and the contained graphic, enabling advanced layout and rendering of graphical content such as images, charts, or diagrams within the document.
/// </summary>
public interface GraphicFrame : OfficeArtExtendableElement
{
  /// <summary>
  /// Non-visual properties for the graphic frame, including identifiers, names, and descriptive information for the frame element.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual properties specific to the graphic frame, such as locking and extension settings for advanced configuration.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }

  /// <summary>
  /// The 2D transformation applied to the graphic frame, including translation, scaling, rotation, and skew, which determines the frame's position and orientation.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  /// The graphic content contained within the frame, which may include images, charts, diagrams, or other graphical objects.
  /// </summary>
  public Graphic? Graphic { get; set; }
}