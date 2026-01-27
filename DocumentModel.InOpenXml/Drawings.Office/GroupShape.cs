namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShape Class.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShape))]
public partial class GroupShape : ModelElement<DXOD.GroupShape>
{
 [OpenXmlProperty(nameof(DXOD.GroupShape.GroupShapeNonVisualProperties))]
 public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

 private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
 [OpenXmlProperty(nameof(DXOD.GroupShape.GroupShapeProperties))]
 public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

 private GroupShapeProperties? _GroupShapeProperties;
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

 private Shape? _Shape;
 public GroupShape? ChildGroupShape { get => _ChildGroupShape; set => UpdateField(ref _ChildGroupShape, value, nameof(ChildGroupShape)); }

 private GroupShape? _ChildGroupShape;
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}