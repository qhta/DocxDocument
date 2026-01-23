namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeType : ModelElement<DXOD.GroupShapeType>
{
    /// <summary>
    ///   GroupShapeNonVisualProperties.
    /// </summary>
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    /// <summary>
    ///   GroupShapeProperties.
    /// </summary>
    public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

    private GroupShapeProperties? _GroupShapeProperties;
}