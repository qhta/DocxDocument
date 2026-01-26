namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a complex field character in the text run of a WordprocessingML document.
/// A complex field character is a special character that delimits the start and end of a complex field or separates its field codes from its current field result. Two complex field characters are required: a start character, which specifies the beginning of a complex field within the document content, and an end character, which specifies the end of a complex field. This syntax allows multiple fields to be embedded within each other. These two items are separated by the optional separator character, which defines the end of the field codes and the beginning of the field contents. When the separator character is missing, it specifies that the field has no result.
/// </summary>
[OpenXmlType(typeof(DXW.FieldChar))]
public partial class FieldChar : ModelElement<DXW.FieldChar>, IRunContent
{
 /// <summary>
 /// IField character type, specifying whether this is a start, separator, or end character for the complex field.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.FieldCharType))]
 /// <summary>
 /// IField character type, specifying whether this is a start, separator, or end character for the complex field.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public FieldCharKind? FieldCharType { get => _FieldCharType; set => UpdateField(ref _FieldCharType, value, nameof(FieldCharType)); }

 private FieldCharKind? _FieldCharType;
 /// <summary>
 /// Indicates whether the field should not be recalculated.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.FieldLock))]
 /// <summary>
 /// Indicates whether the field should not be recalculated.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public bool? FieldLock { get => _FieldLock; set => UpdateField(ref _FieldLock, value, nameof(FieldLock)); }

 private bool? _FieldLock;
 /// <summary>
 /// Indicates whether the field result is invalidated and needs to be updated.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.Dirty))]
 /// <summary>
 /// Indicates whether the field result is invalidated and needs to be updated.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public bool? Dirty { get => _Dirty; set => UpdateField(ref _Dirty, value, nameof(Dirty)); }

 private bool? _Dirty;
 /// <summary>
 /// Custom field data associated with the field character.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.FieldData))]
 /// <summary>
 /// Custom field data associated with the field character.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public string? FieldData { get => _FieldData; set => UpdateField(ref _FieldData, value, nameof(FieldData)); }

 private string? _FieldData;
 /// <summary>
 /// Form field properties associated with the field character.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.FormFieldData))]
 /// <summary>
 /// Form field properties associated with the field character.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public FormFieldData? FormFieldData { get => _FormFieldData; set => UpdateField(ref _FormFieldData, value, nameof(FormFieldData)); }

 private FormFieldData? _FormFieldData;
 /// <summary>
 /// Previous numbering field properties associated with the field character.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FieldChar.NumberingChange))]
 /// <summary>
 /// Previous numbering field properties associated with the field character.
 /// </summary>
 [OpenXmlElement(typeof(DXW.FieldChar))]
 public NumberingChange? NumberingChange { get => _NumberingChange; set => UpdateField(ref _NumberingChange, value, nameof(NumberingChange)); }

 private NumberingChange? _NumberingChange;
}