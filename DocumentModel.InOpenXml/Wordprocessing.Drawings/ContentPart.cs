using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a content part in a WordprocessingML document, providing properties for visual and non-visual shape properties, transformation, and extension data.
/// This class enables advanced configuration and management of embedded or linked content parts, supporting black-and-white rendering, relationship references, and OfficeArt extensions.
/// </summary>
[OpenXmlType(typeof(DXO10W.ContentPart))]
public partial class ContentPart : ModelElement<DXO10W.ContentPart>, IOfficeArtExtendableElement
{
 /// <summary>
 /// Black-and-white rendering mode for the content part.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.BlackWhiteMode))]
 /// <summary>
 /// Black-and-white rendering mode for the content part.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ContentPart))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 /// Relationship ID referencing the associated content part.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.RelationshipId))]
 /// <summary>
 /// Relationship ID referencing the associated content part.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ContentPart))]
 public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

 private string? _RelationshipId;
 /// <summary>
 /// Non-visual shape properties for the content part, specifying metadata and configuration not directly affecting rendering.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.WordNonVisualContentPartShapeProperties))]
 /// <summary>
 /// Non-visual shape properties for the content part, specifying metadata and configuration not directly affecting rendering.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ContentPart))]
 public DMWD.WordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get => _WordNonVisualContentPartShapeProperties; set => UpdateField(ref _WordNonVisualContentPartShapeProperties, value, nameof(WordNonVisualContentPartShapeProperties)); }

 private DMWD.WordNonVisualContentPartShapeProperties? _WordNonVisualContentPartShapeProperties;
 /// <summary>
 /// 2D transformation properties for the content part, specifying scaling, rotation, and translation.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContentPart.Transform2D))]
 /// <summary>
 /// 2D transformation properties for the content part, specifying scaling, rotation, and translation.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ContentPart))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 [OpenXmlProperty(nameof(DXO10W.ContentPart.OfficeArtExtensionList))]
 [OpenXmlElement(typeof(DXO10W.ContentPart))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}