namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a single caption type definition in a Wordprocessing document.
/// This class provides properties for caption type name, placement, chapter numbering, heading style, label inclusion, numbering format, and separator, enabling advanced configuration and management of captions.
/// </summary>
[OpenXmlType(typeof(DXW.Caption))]
public partial class CaptionDefinition : ModelElement<DXW.Caption>
{
 /// <summary>
 /// Specifies the literal string component of this caption.
 /// This value is used as follows:
 /// <list type="bullet">
 /// <item>It is added to the field containing the chapter number and item number of this
 /// object when a caption is automatically added to the document.</item>
 /// <item>It is used to uniquely label this caption type, allowing it to be linked with classes
 /// of objects via the AutoCaption element</item>
 /// <item>It can be used to label this caption type in a user class.</item>
 /// </list>
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
 /// <summary>
 /// Specifies how an automatically inserted caption shall be positioned relative to the object that it is captioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.Position))]
 public CaptionPosition? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }
 private CaptionPosition? _Position;
 /// <summary>
 /// Specifies whether to display numbering associated with the most recent chapter
 /// heading in the WordprocessingML document within the caption field.A chapter heading
 /// is a paragraph of text within a WordprocessingML document that is formatted with a
 ///  style that has been specified by the heading attribute to demarcate chapters in documents.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.ChapterNumber))]
 public bool? ChapterNumber { get => _ChapterNumber; set => UpdateField(ref _ChapterNumber, value, nameof(ChapterNumber)); }
 private bool? _ChapterNumber;
 /// <summary>
 /// Specifies the given style that is used to demarcate chapter headings in a document.
 /// Values from 1 to 9 correspond to the built-in heading styles Heading 1 to Heading 9.
 /// Any other value are application-defined and can be ignored.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.Heading))]
 public int? Heading { get => _Heading; set => UpdateField(ref _Heading, value, nameof(Heading)); }
 private int? _Heading;
 /// <summary>
 /// Specifies if the string specified in the name attribute shall be included in the resulting
 /// caption when it is automatically added to the document. If set to true, then the label text
 /// in the name attribute is omitted when adding the caption.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.NoLabel))]
 public bool? NoLabel { get => _NoLabel; set => UpdateField(ref _NoLabel, value, nameof(NoLabel)); }
 private bool? _NoLabel;
 /// <summary>
 /// Caption numbering format, specifying the format used for numbering captions.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.NumberFormat))]
 public NumberFormat? NumberFormat { get => _NumberFormat; set => UpdateField(ref _NumberFormat, value, nameof(NumberFormat)); }
 private NumberFormat? _NumberFormat;
 /// <summary>
 /// Specifies the character which shall be used to separate the chapter number used in this
 /// caption from the caption item numbering.A caption format consists of three components:
 /// <list type="bullet">
 /// <item>The (optional) literal string</item>
 /// <item>The (optional) chapter number</item>
 /// <item>The index of this caption within the chapter/document</item>
 /// </list>
 /// When the latter two items are both present, they are delimited using the chapter separator specified by this attribute.
 /// If this attribute is omitted, then its default value shall be a hyphen.
 /// If the chapter number is not part of the caption format, then this parameter shall be ignored.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Caption.Separator))]
 public ChapterSeparator? Separator { get => _Separator; set => UpdateField(ref _Separator, value, nameof(Separator)); }
 private ChapterSeparator? _Separator;
}