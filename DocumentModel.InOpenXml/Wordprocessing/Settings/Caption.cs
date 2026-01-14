namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single caption type definition in a Wordprocessing document.
/// This class provides properties for caption type name, placement, chapter numbering, heading style, label inclusion, numbering format, and separator, enabling advanced configuration and management of captions.
/// </summary>
public class Caption: CaptionDef
{

  /// <summary>
  /// Caption type name, specifying the name of the caption type.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Automatic caption placement, specifying where the caption is placed relative to the object.
  /// </summary>
  public CaptionPositionKind? Position { get; set; }

  /// <summary>
  /// Indicates whether the chapter number is included in the field for the caption.
  /// </summary>
  public bool? ChapterNumber { get; set; }

  /// <summary>
  /// Style for chapter headings, specifying the heading style used for chapter numbering.
  /// </summary>
  public Int32? Heading { get; set; }

  /// <summary>
  /// Indicates whether the name is excluded from the caption.
  /// </summary>
  public bool? NoLabel { get; set; }

  /// <summary>
  /// Caption numbering format, specifying the format used for numbering captions.
  /// </summary>
  public NumberFormatKind? NumberFormat { get; set; }

  /// <summary>
  /// Chapter number/item index separator, specifying the separator used between chapter number and item index.
  /// </summary>
  public ChapterSeparatorKind? Separator { get; set; }
}