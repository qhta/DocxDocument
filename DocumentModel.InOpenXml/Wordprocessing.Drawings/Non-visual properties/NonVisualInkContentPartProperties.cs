using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents non-visual properties for an ink content part in a Wordprocessing document.
/// This class provides configuration for comment status, content part locks, and extension data, enabling control over editing restrictions and extensibility for ink content parts.
/// </summary>
[OpenXmlType(typeof(DXO10W.NonVisualInkContentPartProperties))]
[XmlRoot("NonVisualInkContentPartProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class NonVisualInkContentPartProperties : ModelElement<DXO10W.WordNonVisualContentPartShapeProperties>
{
 /// <summary>
 /// Indicates whether the ink content part is associated with a comment, distinguishing it from other ink elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.NonVisualInkContentPartProperties.IsComment))]
 public bool? IsComment { get => _IsComment; set => UpdateField(ref _IsComment, value, nameof(IsComment)); }

 private bool? _IsComment;
 /// <summary>
 /// The set of locks applied to the content part, restricting modifications or interactions as defined by the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.NonVisualInkContentPartProperties.ContentPartLocks))]
 public ContentPartLocks? ContentPartLocks { get => _ContentPartLocks; set => UpdateField(ref _ContentPartLocks, value, nameof(ContentPartLocks)); }

 private ContentPartLocks? _ContentPartLocks;
 /// <summary>
 /// List of OfficeArt extensions associated with the ink content part, allowing for additional metadata or custom features.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.NonVisualInkContentPartProperties.OfficeArtExtensionList))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}