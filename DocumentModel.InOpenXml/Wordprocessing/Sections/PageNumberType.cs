namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page number type settings for a section in a Wordprocessing document.
/// This class provides properties for page number format, starting page number, chapter heading style, and chapter separator character, enabling advanced configuration of page numbering and chapter formatting.
/// </summary>
[OpenXmlType(typeof(DXW.PageNumberType))]
public partial class PageNumberType: ModelElement<DXW.PageNumberType>, ISectionPropertiesContent
{
  /// <summary>
  /// Page number format, specifying the numbering style for pages.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PageNumberType.Format))]
  public NumberFormat? Format { get => _Format; set => UpdateField(ref _Format, value, nameof(Format)); }

  private NumberFormat? _Format;

  /// <summary>
  /// Starting page number for the section.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PageNumberType.Start))]
  public Int32? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }

  private Int32? _Start;

  /// <summary>
  /// Specifies the one-based index of the heading style applied to chapter titles in the
  /// document which shall be used as chapter headings in all page numbers for this section,
  /// by locating the nearest heading of that style and extracting the numbering information.
  /// </summary>
  /// <remarks>
  /// If the specified heading style does not exist in the current section, or does not have a
  /// numbering format, then any previous level heading format shall be used as needed as the
  /// specified chapter number.If no heading has numbering information and/or is used in the
  /// section, then the chapter and chapter separator shall be omitted from the page
  /// numbering data.
  /// <example>
  /// Consider a page number in a section with page numbering properties that
  /// specify a chapStyle of 1 (Heading 1 style) and a chapSep of dash.
  /// This means that for each page number in this section, the numbering value of the nearest
  /// Heading 1 style is used for the chapter value, and is followed by a dash,
  /// then the page number in that section.
  /// </example>  
  /// </remarks>
  [OpenXmlProperty(nameof(DXW.PageNumberType.ChapterStyle))]
  public Byte? ChapterStyle
  {
    get => _ChapterStyle;
    set => UpdateField(ref _ChapterStyle, value, nameof(ChapterStyle));
  }

  private Byte? _ChapterStyle;

  /// <summary>
  /// Chapter separator character, specifying the character used to separate chapter numbers from page numbers.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PageNumberType.ChapterSeparator))]
  public ChapterSeparator? ChapterSeparator
  {
    get => _ChapterSeparator;
    set => UpdateField(ref _ChapterSeparator, value, nameof(ChapterSeparator));
  }

  private ChapterSeparator? _ChapterSeparator;
}