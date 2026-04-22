namespace DocumentModel.Drawings;
/// <summary>
///   Represents a text paragraph, including properties, runs, breaks, fields, math, and end run formatting.
/// </summary>
[OpenXmlType(typeof(DXD.Paragraph))]
[XmlRoot("Paragraph", Namespace = "DocumentModel.Drawings")]
public partial class Paragraph : ModelElement<DXD.Paragraph>
{
 /// <summary>
 ///   Properties for the text paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Paragraph.ParagraphProperties))]
 public ParagraphProperties? ParagraphProperties { get => _ParagraphProperties; set => UpdateField(ref _ParagraphProperties, value, nameof(ParagraphProperties)); }
 private ParagraphProperties? _ParagraphProperties;

 /// <summary>
 ///   Text run within the paragraph.
 /// </summary>
 public Run? Run { get => _Run; set => UpdateField(ref _Run, value, nameof(Run)); }
 private Run? _Run;

 /// <summary>
 ///   Line break within the paragraph.
 /// </summary>
 public Break? Break { get => _Break; set => UpdateField(ref _Break, value, nameof(Break)); }
 private Break? _Break;

 /// <summary>
 ///   Field element within the paragraph.
 /// </summary>
 public Field? Field { get => _Field; set => UpdateField(ref _Field, value, nameof(Field)); }
 private Field? _Field;

 /// <summary>
 ///   Indicates whether the paragraph contains mathematical text.
 /// </summary>
 public bool? TextMath { get => _TextMath; set => UpdateField(ref _TextMath, value, nameof(TextMath)); }
 private bool? _TextMath;

 /// <summary>
 ///   Formatting properties for the last run in the paragraph.
 /// </summary>
 public EndParagraphRunProperties? EndParagraphRunProperties { get => _EndParagraphRunProperties; set => UpdateField(ref _EndParagraphRunProperties, value, nameof(EndParagraphRunProperties)); }
 private EndParagraphRunProperties? _EndParagraphRunProperties;
}