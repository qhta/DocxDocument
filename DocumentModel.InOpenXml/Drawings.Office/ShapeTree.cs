namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree : ModelElement<DXOD.ShapeTree>
{
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

    private GroupShapeProperties? _GroupShapeProperties;
    public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

    private Shape? _Shape;
    public GroupShape? GroupShape { get => _GroupShape; set => UpdateField(ref _GroupShape, value, nameof(GroupShape)); }

    private GroupShape? _GroupShape;
    public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }

    private OfficeArtExtensionList? _OfficeArtExtensionList;
}