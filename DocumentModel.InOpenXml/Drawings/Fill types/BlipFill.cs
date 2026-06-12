namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blip fill, providing properties for image fill effects in drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.BlipFill))]
[XmlRoot("BlipFill", Namespace = "DocumentModel.Drawings")]
public partial class BlipFill : Fill<DXD.BlipFill>
{
 /// <summary>
 /// DPI (dots per inch) setting for the blip fill.
 /// </summary>
 public UInt32? Dpi { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Gets or sets a value indicating whether the fill rotates with the shape.
 /// </summary>
 public bool? RotateWithShape { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Blip (image) used for the fill.
 /// </summary>
 public Blip? Blip { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Source rectangle, which defines the portion of the image to use.
 /// </summary>
 public RelativeRectangleType? SourceRectangle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Tile settings for the blip fill.
 /// </summary>
 public Tile? Tile { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Stretch settings for the blip fill.
 /// </summary>
 public Stretch? Stretch { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}