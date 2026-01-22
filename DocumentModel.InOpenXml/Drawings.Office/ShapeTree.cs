namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree : ModelElement<DXOD.ShapeTree>
{
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    public GroupShapeProperties? GroupShapeProperties { get; set; }
    public Shape? Shape { get; set; }
    public GroupShape? GroupShape { get; set; }
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}