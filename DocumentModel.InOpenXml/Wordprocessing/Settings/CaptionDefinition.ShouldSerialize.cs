namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single caption type definition in a Wordprocessing document.
/// This class provides properties for caption type name, placement, chapter numbering, heading style, label inclusion, numbering format, and separator, enabling advanced configuration and management of captions.
/// </summary>
public partial class CaptionDefinition
{

  /// <summary>
  /// Caption type name, specifying the name of the caption type.
  /// </summary>
  public bool ShouldSerializeName() => Name is not null;

  /// <summary>
  /// Automatic caption placement, specifying where the caption is placed relative to the object.
  /// </summary>
  public bool ShouldSerializePosition() => Position is not null;

  /// <summary>
  /// Indicates whether the chapter number is included in the field for the caption.
  /// </summary>
  public bool ShouldSerializeChapterNumber() => ChapterNumber is not null;

  /// <summary>
  /// Style for chapter headings, specifying the heading style used for chapter numbering.
  /// </summary>
  public bool ShouldSerializeHeading() => Heading is not null;

  /// <summary>
  /// Indicates whether the name is excluded from the caption.
  /// </summary>
  public bool ShouldSerializeNoLabel() => NoLabel is not null;

  /// <summary>
  /// Caption numbering format, specifying the format used for numbering captions.
  /// </summary>
  public bool ShouldSerializeNumberFormat() => NumberFormat is not null;

  /// <summary>
  /// Chapter number/item index separator, specifying the separator used between chapter number and item index.
  /// </summary>
  public bool ShouldSerializeSeparator() => Separator is not null;
}