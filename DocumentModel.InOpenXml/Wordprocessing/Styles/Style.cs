namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a style (paragraph style, character style, etc.) in the document.
///   This class provides properties for style name, type, base style, next paragraph style, update and visibility flags, paragraph and font formatting, and parent application, enabling advanced style management and formatting for document content.
/// </summary>
[OpenXmlType(typeof(DXW.Style))]
[XmlRoot("Style", Namespace = "DocumentModel.Wordprocessing")]
public partial class Style : ModelElement<DXW.Style>
{
 /// <summary>
 /// Name of the style as defined in the document.
 /// </summary>
 public string? NameLocal { get => _NameLocal; set => UpdateField(ref _NameLocal, value, nameof(NameLocal)); }

 private string? _NameLocal;
 /// <summary>
 /// Built-in style identifier, specifying the predefined style type.
 /// </summary>
 [NotMapped]
 public BuiltInStyleType? BuiltIn { get => _BuiltIn; set => UpdateField(ref _BuiltIn, value, nameof(BuiltIn)); }

 private BuiltInStyleType? _BuiltIn;
 /// <summary>
 /// Type of style, such as paragraph, character, table, or numbering.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Style.Type))]
 public StyleType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private StyleType? _Type;
 /// <summary>
 /// Base style on which this style is based, enabling inheritance of formatting.
 /// </summary>
 public Style? BaseStyle { get => _BaseStyle; set => UpdateField(ref _BaseStyle, value, nameof(BaseStyle)); }

 private Style? _BaseStyle;
 /// <summary>
 /// Next paragraph style to be applied after this style.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Style.NextParagraphStyle))]
 public Style? NextParagraphStyle { get => _NextParagraphStyle; set => UpdateField(ref _NextParagraphStyle, value, nameof(NextParagraphStyle)); }

 private Style? _NextParagraphStyle;
 /// <summary>
 /// Indicates whether the style is automatically updated when formatting changes are made.
 /// </summary>
 public bool? AutomaticallyUpdate { get => _AutomaticallyUpdate; set => UpdateField(ref _AutomaticallyUpdate, value, nameof(AutomaticallyUpdate)); }

 private bool? _AutomaticallyUpdate;
 /// <summary>
 /// Indicates whether the style is hidden from the style gallery and UI.
 /// </summary>
 public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }

 private bool? _Hidden;
}