namespace DocumentModel.Drawings.Office;
/// <summary>
///   Represents a DrawingML group shape in Office documents, providing a container for grouping multiple shapes and graphical elements.
///   Enables hierarchical organization, transformation, and formatting of grouped shapes in Office drawings.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShape))]
[XmlRoot("GroupShape", Namespace = "DocumentModel.Drawings.Office")]
public partial class GroupShape : ModelElement<DXOD.GroupShape>
{
 /// <summary>
 ///   Non-visual properties for the group shape, including IDs, names, and locking information.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShape.GroupShapeNonVisualProperties))]
 public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

 private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
 /// <summary>
 ///   Properties for the group shape, specifying layout, transformation, and formatting for the shape group.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShape.GroupShapeProperties))]
 public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

 private GroupShapeProperties? _GroupShapeProperties;
 /// <summary>
 ///   A single shape contained within the group shape, representing an individual graphical element.
 /// </summary>
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

 private Shape? _Shape;
 /// <summary>
 ///   A nested group shape contained within this group shape, enabling hierarchical grouping of shapes.
 /// </summary>
 public GroupShape? ChildGroupShape { get => _ChildGroupShape; set => UpdateField(ref _ChildGroupShape, value, nameof(ChildGroupShape)); }

 private GroupShape? _ChildGroupShape;
 /// <summary>
 ///   List of OfficeArt extension elements for the group shape, supporting extensibility and application-specific data.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}