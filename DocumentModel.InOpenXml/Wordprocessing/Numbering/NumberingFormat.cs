namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the numbering format for a numbering definition in a WordprocessingML document.
/// This class provides properties for specifying the standard numbering format type and a custom number format using XSLT syntax, enabling advanced customization of list and outline numbering styles.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingFormat))]
[XmlRoot("NumberingFormat", Namespace = "DocumentModel.Wordprocessing")]
public partial class NumberingFormat : ModelElement<DXW.NumberingFormat>
{
 /// <summary>
 /// Standard numbering format type, specifying the built-in numbering style (e.g., decimal, roman, bullet).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingFormat.Val))]
 public NumberFormat? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private NumberFormat? _Type;
 /// <summary>
 /// Custom number format using XSLT format attribute syntax. This format is used for all numbering in the parent object (e.g., Katakana numbering).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.NumberingFormat.Format))]
 public string? Custom { get => _Custom; set => UpdateField(ref _Custom, value, nameof(Custom)); }

 private string? _Custom;
}