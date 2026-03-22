namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for text content controls in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides a property for allowing soft line breaks, enabling advanced customization of multiline or single-line text input in SDTs.
/// </summary>
[OpenXmlType(typeof(DXW.SdtContentText))]
public partial class SdtContentText : ModelElement<DXW.SdtContentText>
{
 /// <summary>
 /// Indicates whether soft line breaks (multiline input) are allowed in the text content control.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentText.MultiLine))]
 public bool? MultiLine { get => _MultiLine; set => UpdateField(ref _MultiLine, value, nameof(MultiLine)); }
 private bool? _MultiLine;
}