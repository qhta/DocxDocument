namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the page number type settings for a section in a Wordprocessing document.
/// This class provides properties for page number format, starting page number, chapter heading style, and chapter separator character, enabling advanced configuration of page numbering and chapter formatting.
/// </summary>
[OpenXmlType(typeof(DXW.PageNumberType))]
public partial class PageNumberType : ModelElement<DXW.PageNumberType>, ISectionPropertiesContent
{
 /// <summary>
 /// Page number format, specifying the numbering style for pages.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageNumberType.Format))]
 public NumberFormatKind? Format { get => _Format; set => UpdateField(ref _Format, value, nameof(Format)); }

 private NumberFormatKind? _Format;
 /// <summary>
 /// Starting page number for the section.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageNumberType.Start))]
 public Int32? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }

 private Int32? _Start;
 /// <summary>
 /// Chapter heading style, specifying the style used for chapter numbering.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageNumberType.ChapterStyle))]
 public Byte? ChapterStyle { get => _ChapterStyle; set => UpdateField(ref _ChapterStyle, value, nameof(ChapterStyle)); }

 private Byte? _ChapterStyle;
 /// <summary>
 /// Chapter separator character, specifying the character used to separate chapter numbers from page numbers.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageNumberType.ChapterSeparator))]
 public ChapterSeparatorKind? ChapterSeparator { get => _ChapterSeparator; set => UpdateField(ref _ChapterSeparator, value, nameof(ChapterSeparator)); }

 private ChapterSeparatorKind? _ChapterSeparator;
}