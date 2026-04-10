using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents a content part in a WordprocessingML document, providing properties for visual and non-visual shape properties, transformation, and extension data.
///   Enables advanced configuration and management of embedded or linked content parts, supporting black-and-white rendering, relationship references, and OfficeArt extensions.
/// </summary>
[OpenXmlType(typeof(DXO10W.ContentPart))]
[XmlRoot("ContentPart", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class ContentPart : ModelElement<DXO10W.ContentPart>, IOfficeArtExtendableElement
{
 /// <summary>
 ///   Black-and-white rendering mode for the content part, controlling how the part is displayed in monochrome or grayscale output.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.BlackWhiteMode))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   Relationship ID referencing the associated content part, linking this shape to an embedded or external resource.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.RelationshipId))]
 public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

 private string? _RelationshipId;
 /// <summary>
 ///   Non-visual shape properties for the content part, specifying metadata and configuration not directly affecting rendering (e.g., IDs, names, or locks).
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.WordNonVisualContentPartShapeProperties))]
 public WordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get => _WordNonVisualContentPartShapeProperties; set => UpdateField(ref _WordNonVisualContentPartShapeProperties, value, nameof(WordNonVisualContentPartShapeProperties)); }

 private WordNonVisualContentPartShapeProperties? _WordNonVisualContentPartShapeProperties;
 /// <summary>
 ///   2D transformation properties for the content part, specifying scaling, rotation, and translation for layout and positioning.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.Transform2D))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 /// <summary>
 ///   List of OfficeArt extension elements for the content part, allowing for future extensibility and application-specific data.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}