namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the placeholder configuration for a structured document tag (SDT) in a Wordprocessing document.
/// This class provides a property for referencing a document part to be used as placeholder text, enabling advanced customization of placeholder content for SDTs.
/// </summary>
[OpenXmlType(typeof(DXW.SdtPlaceholder))]
public partial class SdtPlaceholder : ModelElement<DXW.SdtPlaceholder>
{
 /// <summary>
 /// Document part reference used as placeholder text for the SDT.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtPlaceholder.DocPartReference))]
 /// <summary>
 /// Document part reference used as placeholder text for the SDT.
 /// </summary>
 [OpenXmlElement(typeof(DXW.SdtPlaceholder))]
 public string? DocPartReference { get => _DocPartReference; set => UpdateField(ref _DocPartReference, value, nameof(DocPartReference)); }

 private string? _DocPartReference;
}