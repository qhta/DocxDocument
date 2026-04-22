namespace DocumentModel.Drawings.Office;
/// <summary>
///   Represents a DrawingML shape tree in Office documents, providing the root container for shapes, groups, and graphical elements.
///   Enables advanced grouping, layering, and organization of shapes and graphical content in Office drawings.
/// </summary>
[OpenXmlType(typeof(DXOD.ShapeTree))]
[XmlRoot("ShapeTree", Namespace = "DocumentModel.Drawings.Office")]
public partial class ShapeTree : ModelElement<DXOD.ShapeTree>
{
 /// <summary>
 ///   Non-visual properties for the group shape, including IDs, names, and locking information.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeTree.GroupShapeNonVisualProperties))]
 public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }
 private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;

 /// <summary>
 ///   Properties for the group shape, specifying layout, transformation, and formatting for the shape group.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeTree.GroupShapeProperties))]
 public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }
 private GroupShapeProperties? _GroupShapeProperties;

 /// <summary>
 ///   A single shape contained within the shape tree, representing an individual graphical element.
 /// </summary>
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }
 private Shape? _Shape;

 /// <summary>
 ///   A nested group shape contained within the shape tree, enabling hierarchical grouping of shapes.
 /// </summary>
 public GroupShape? GroupShape { get => _GroupShape; set => UpdateField(ref _GroupShape, value, nameof(GroupShape)); }
 private GroupShape? _GroupShape;

 /// <summary>
 ///   List of OfficeArt extension elements for the shape tree, supporting extensibility and application-specific data.
 /// </summary>
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
 private OfficeArtExtensionList? _OfficeArtExtensionList;
}