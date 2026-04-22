namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties for a paragraph in a WordprocessingML document.
/// This class extends <see cref = "AbstractParagraphProperties"/> and provides properties for paragraph mark run formatting, section properties, and tracked changes to paragraph properties, enabling advanced formatting, layout, and revision management for paragraphs.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphProperties))]
[XmlRoot("ParagraphProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphProperties : BaseParagraphProperties<DXW.ParagraphProperties>
{
 /// <summary>
 /// Style ID of the paragraph style used to format the contents of this paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.ParagraphStyleId))]
 public string? ParagraphStyleId { get => _ParagraphStyleId; set => UpdateField(ref _ParagraphStyleId, value, nameof(ParagraphStyleId)); }
 private string? _ParagraphStyleId;

 /// <summary>
 /// HTML div ID for the paragraph, used to map the paragraph to a specific HTML div when saving as HTML. Preserves fidelity of existing HTML documents in WordprocessingML format.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.DivId))]
 public string? DivId { get => _DivId; set => UpdateField(ref _DivId, value, nameof(DivId)); }
 private string? _DivId;

 /// <summary>
 /// Set of conditional table style formatting properties applied to this paragraph, if contained within a table cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.ConditionalFormatStyle))]
 public ConditionalFormatFlags? ConditionalFormatStyle { get => _ConditionalFormatStyle; set => UpdateField(ref _ConditionalFormatStyle, value, nameof(ConditionalFormatStyle)); }
 private ConditionalFormatFlags? _ConditionalFormatStyle;

 /// <summary>
 /// Run properties for the paragraph mark, specifying formatting for the paragraph end character.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.ParagraphMarkRunProperties))]
 public ParagraphMarkRunProperties? ParagraphMarkRunProperties { get => _ParagraphMarkRunProperties; set => UpdateField(ref _ParagraphMarkRunProperties, value, nameof(ParagraphMarkRunProperties)); }
 private ParagraphMarkRunProperties? _ParagraphMarkRunProperties;

 /// <summary>
 /// Section properties associated with the paragraph, specifying layout and configuration for the section containing the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.SectionProperties))]
 public SectionProperties? SectionProperties { get => _SectionProperties; set => UpdateField(ref _SectionProperties, value, nameof(SectionProperties)); }
 private SectionProperties? _SectionProperties;

 /// <summary>
 /// Tracked changes to paragraph properties, enabling revision tracking and management of property changes.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphProperties.ParagraphPropertiesChange))]
 public ParagraphPropertiesChange? ParagraphPropertiesChange { get => _ParagraphPropertiesChange; set => UpdateField(ref _ParagraphPropertiesChange, value, nameof(ParagraphPropertiesChange)); }
 private ParagraphPropertiesChange? _ParagraphPropertiesChange;
}