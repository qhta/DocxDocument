namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree : ModelElement<DXOD.ShapeTree>
{
    [OpenXmlProperty(nameof(DXOD.ShapeTree.GroupShapeNonVisualProperties))]
    [OpenXmlElement(typeof(DXOD.ShapeTree))]
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    [OpenXmlProperty(nameof(DXOD.ShapeTree.GroupShapeProperties))]
    [OpenXmlElement(typeof(DXOD.ShapeTree))]
    public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

    private GroupShapeProperties? _GroupShapeProperties;
    [OpenXmlElement(typeof(DXOD.ShapeTree))]
    public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

    private Shape? _Shape;
    [OpenXmlElement(typeof(DXOD.ShapeTree))]
    public GroupShape? GroupShape { get => _GroupShape; set => UpdateField(ref _GroupShape, value, nameof(GroupShape)); }

    private GroupShape? _GroupShape;
    [OpenXmlElement(typeof(DXOD.ShapeTree))]
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}