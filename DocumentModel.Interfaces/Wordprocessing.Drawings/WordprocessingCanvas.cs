namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a canvas element in a Wordprocessing document for grouping and organizing graphical content.
/// This interface provides access to background formatting, whole formatting, shapes, pictures, groups, graphic frames, and extension data, enabling advanced layout and rendering of graphical objects within the document.
/// </summary>
public interface WordprocessingCanvas
{

  /// <summary>
  /// Background formatting settings for the canvas, specifying fill, effects, and other background properties.
  /// </summary>
  public BackgroundFormatting? BackgroundFormatting { get; set; }

  /// <summary>
  /// Whole formatting settings for the canvas, specifying outline and effects applied to the entire canvas.
  /// </summary>
  public WholeFormatting? WholeFormatting { get; set; }

  /// <summary>
  /// A shape element contained within the canvas, representing an individual graphical object.
  /// </summary>
  public Shape? WordprocessingShape { get; set; }

  /// <summary>
  /// A picture element contained within the canvas, representing an embedded image.
  /// </summary>
  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }

  /// <summary>
  /// A group of drawing elements contained within the canvas, enabling hierarchical organization of graphical content.
  /// </summary>
  public WordprocessingGroup? WordprocessingGroup { get; set; }

  /// <summary>
  /// A graphic frame type element contained within the canvas, used for advanced graphical content such as images, charts, or diagrams.
  /// </summary>
  public GraphicFrameType? GraphicFrameType { get; set; }

  /// <summary>
  /// List of OfficeArt extensions associated with the canvas, allowing for additional metadata or custom features.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}