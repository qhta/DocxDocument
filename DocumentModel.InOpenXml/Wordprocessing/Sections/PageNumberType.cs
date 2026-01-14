namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page number type settings for a section in a Wordprocessing document.
/// This interface provides properties for page number format, starting page number, chapter heading style, and chapter separator character, enabling advanced configuration of page numbering and chapter formatting.
/// </summary>
public interface PageNumberType : ISectionPropertiesContent
{

  /// <summary>
  /// Page number format, specifying the numbering style for pages.
  /// </summary>
  public NumberFormatKind? Format { get; set; }

  /// <summary>
  /// Starting page number for the section.
  /// </summary>
  public Int32? Start { get; set; }

  /// <summary>
  /// Chapter heading style, specifying the style used for chapter numbering.
  /// </summary>
  public Byte? ChapterStyle { get; set; }

  /// <summary>
  /// Chapter separator character, specifying the character used to separate chapter numbers from page numbers.
  /// </summary>
  public ChapterSeparatorKind? ChapterSeparator { get; set; }
}