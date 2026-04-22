namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a group of drawing elements within a Wordprocessing document.
/// This class provides access to non-visual properties, group properties, child shapes, graphic frames, pictures, and extension data, enabling hierarchical organization and advanced layout of graphical content.
/// </summary>
[OpenXmlType(typeof(DXO10WDG.WordprocessingGroup))]
[XmlRoot("WordprocessingGroup", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class WordprocessingGroup : WordprocessingGroupType<DXO10WDG.WordprocessingGroup>
{
 /// <summary>
 /// A shape element contained within the group, representing an individual graphical object.
 /// </summary>
 public Shape? WordprocessingShape { get => _WordprocessingShape; set => UpdateField(ref _WordprocessingShape, value, nameof(WordprocessingShape)); }
 private Shape? _WordprocessingShape;

 /// <summary>
 /// A child group shape element, enabling nested grouping of shapes for hierarchical organization.
 /// </summary>
 public GroupShape? GroupShape { get => _GroupShape; set => UpdateField(ref _GroupShape, value, nameof(GroupShape)); }
 private GroupShape? _GroupShape;

 /// <summary>
 /// A graphic frame element contained within the group, used for advanced graphical content such as images, charts, or diagrams.
 /// </summary>
 public GraphicFrame? GraphicFrame { get => _GraphicFrame; set => UpdateField(ref _GraphicFrame, value, nameof(GraphicFrame)); }
 private GraphicFrame? _GraphicFrame;

 /// <summary>
 /// A picture element contained within the group, representing an embedded image.
 /// </summary>
 public DocumentModel.Drawings.Pictures.Picture? Picture { get => _Picture; set => UpdateField(ref _Picture, value, nameof(Picture)); }
 private DocumentModel.Drawings.Pictures.Picture? _Picture;

 /// <summary>
 /// List of OfficeArt extensions associated with the group, allowing for additional metadata or custom features.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}