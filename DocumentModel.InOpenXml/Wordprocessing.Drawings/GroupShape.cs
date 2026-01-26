namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a group shape element within a Wordprocessing document drawing group.
/// This class provides access to non-visual properties, group properties, child shapes, graphic frames, pictures, and extension data, enabling hierarchical organization and advanced layout of graphical content.
/// </summary>
[OpenXmlType(typeof(DXD.GroupShape))]
public partial class GroupShape : ModelElement<DXD.GroupShape>, DMD.IOfficeArtExtendableElement
{
 /// <summary>
 /// Non-visual properties for the group shape, including identifiers, names, and descriptive information.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

 private NonVisualDrawingProperties? _NonVisualDrawingProperties;
 /// <summary>
 /// Non-visual properties specific to group drawing shapes, such as locking and extension settings.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get => _NonVisualGroupDrawingShapeProperties; set => UpdateField(ref _NonVisualGroupDrawingShapeProperties, value, nameof(NonVisualGroupDrawingShapeProperties)); }

 private NonVisualGroupDrawingShapeProperties? _NonVisualGroupDrawingShapeProperties;
 /// <summary>
 /// Properties for the group shape, including layout, transformation, and grouping behavior.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

 private GroupShapeProperties? _GroupShapeProperties;
 /// <summary>
 /// A shape element contained within the group, representing an individual graphical object.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public Shape? WordprocessingShape { get => _WordprocessingShape; set => UpdateField(ref _WordprocessingShape, value, nameof(WordprocessingShape)); }

 private Shape? _WordprocessingShape;
 /// <summary>
 /// A child group shape element, enabling nested grouping of shapes for hierarchical organization.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public GroupShape? ChildGroupShape { get => _ChildGroupShape; set => UpdateField(ref _ChildGroupShape, value, nameof(ChildGroupShape)); }

 private GroupShape? _ChildGroupShape;
 /// <summary>
 /// A graphic frame element contained within the group, used for advanced graphical content such as images, charts, or diagrams.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public GraphicFrame? GraphicFrame { get => _GraphicFrame; set => UpdateField(ref _GraphicFrame, value, nameof(GraphicFrame)); }

 private GraphicFrame? _GraphicFrame;
 /// <summary>
 /// A picture element contained within the group, representing an embedded image.
 /// </summary>
 [OpenXmlElement(typeof(DXD.GroupShape))]
 public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

 private OfficeArtExtensionList? _OfficeArtExtensionList;
}