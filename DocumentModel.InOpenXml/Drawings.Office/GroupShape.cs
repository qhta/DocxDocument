namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShape Class.
/// </summary>
public partial class GroupShape : ModelElement<DXOD.GroupShape>
{
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    public GroupShapeProperties? GroupShapeProperties { get; set; }
    public Shape? Shape { get; set; }
    public GroupShape? ChildGroupShape { get; set; }
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}