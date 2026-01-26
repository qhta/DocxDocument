namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the document part type configuration for a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for filtering document parts by gallery and category, and for indicating built-in document parts, enabling advanced customization and management of document part selection in SDTs.
/// </summary>
[OpenXmlType(typeof(DXW.SdtDocPartType))]
public partial class SdtDocPartType : ModelElement<DXW.SdtDocPartType>
{
 /// <summary>
 /// Document part gallery filter, specifying the gallery to filter document parts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtDocPartType.DocPartGallery))]
 [OpenXmlElement(typeof(DXW.SdtDocPartType))]
 public string? DocPartGallery { get => _DocPartGallery; set => UpdateField(ref _DocPartGallery, value, nameof(DocPartGallery)); }

 private string? _DocPartGallery;
 /// <summary>
 /// Document part category filter, specifying the category to filter document parts.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtDocPartType.DocPartCategory))]
 [OpenXmlElement(typeof(DXW.SdtDocPartType))]
 public string? DocPartCategory { get => _DocPartCategory; set => UpdateField(ref _DocPartCategory, value, nameof(DocPartCategory)); }

 private string? _DocPartCategory;
 /// <summary>
 /// Indicates whether the document part is built-in and unique.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtDocPartType.DocPartUnique))]
 [OpenXmlElement(typeof(DXW.SdtDocPartType))]
 public bool? DocPartUnique { get => _DocPartUnique; set => UpdateField(ref _DocPartUnique, value, nameof(DocPartUnique)); }

 private bool? _DocPartUnique;
}