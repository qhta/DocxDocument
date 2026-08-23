namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a group shape element within a Wordprocessing document drawing group.
/// This class provides access to non-visual properties, group properties, child shapes, graphic frames, pictures, and extension data, enabling hierarchical organization and advanced layout of graphical content.
/// </summary>
[OpenXmlType(typeof(DXO10WDG.GroupShape))]
[DataContract]
[XmlRoot("GroupShape", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class GroupShape : WordprocessingGroupType<DXO10WDG.GroupShape>, DMD.IOfficeArtExtendableElement
{
  /// <summary>
  /// A shape element contained within the group, representing an individual graphical object.
  /// </summary>
  public Shape? WordprocessingShape { get => _WordprocessingShape; set => UpdateField(ref _WordprocessingShape, value, nameof(WordprocessingShape)); }
  private Shape? _WordprocessingShape;

  /// <summary>
  /// A child group shape element, enabling nested grouping of shapes for hierarchical organization.
  /// </summary>
  public GroupShape? ChildGroupShape { get => _ChildGroupShape; set => UpdateField(ref _ChildGroupShape, value, nameof(ChildGroupShape)); }
  private GroupShape? _ChildGroupShape;

  /// <summary>
  /// A graphic frame element contained within the group, used for advanced graphical content such as images, charts, or diagrams.
  /// </summary>
  public GraphicFrame? GraphicFrame { get => _GraphicFrame; set => UpdateField(ref _GraphicFrame, value, nameof(GraphicFrame)); }
  private GraphicFrame? _GraphicFrame;

  /// <summary>
  /// A picture element contained within the group, representing an embedded image.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
  private OfficeArtExtensionList? _OfficeArtExtensionList;
}