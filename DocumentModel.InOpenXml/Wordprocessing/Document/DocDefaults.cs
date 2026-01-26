namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the default paragraph and run properties for a WordprocessingML document.
///   This class provides properties for specifying the default character-level and paragraph-level formatting applied to all runs and paragraphs in the document unless overridden by more specific formatting.
/// </summary>
[OpenXmlType(typeof(DXW.DocDefaults))]
public partial class DocDefaults : ModelElement<DXW.DocDefaults>
{
 /// <summary>
 ///   Default run properties, specifying the default character-level formatting for text runs.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocDefaults.RunPropertiesDefault))]
 /// <summary>
 ///   Default run properties, specifying the default character-level formatting for text runs.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DocDefaults))]
 public DefaultRunProperties? RunPropertiesDefault { get => _RunPropertiesDefault; set => UpdateField(ref _RunPropertiesDefault, value, nameof(RunPropertiesDefault)); }

 private DefaultRunProperties? _RunPropertiesDefault;
 /// <summary>
 ///   Default paragraph properties, specifying the default paragraph-level formatting for paragraphs.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocDefaults.ParagraphPropertiesDefault))]
 /// <summary>
 ///   Default paragraph properties, specifying the default paragraph-level formatting for paragraphs.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DocDefaults))]
 public DefaultParagraphProperties? ParagraphPropertiesDefault { get => _ParagraphPropertiesDefault; set => UpdateField(ref _ParagraphPropertiesDefault, value, nameof(ParagraphPropertiesDefault)); }

 private DefaultParagraphProperties? _ParagraphPropertiesDefault;
}