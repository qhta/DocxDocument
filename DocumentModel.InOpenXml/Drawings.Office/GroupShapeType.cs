namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public partial class GroupShapeType : ModelElement<DXOD.GroupShapeType>
{
    /// <summary>
    ///   GroupShapeNonVisualProperties.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.GroupShapeType.GroupShapeNonVisualProperties))]
    /// <summary>
    ///   GroupShapeNonVisualProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.GroupShapeType))]
    public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get => _GroupShapeNonVisualProperties; set => UpdateField(ref _GroupShapeNonVisualProperties, value, nameof(GroupShapeNonVisualProperties)); }

    private GroupShapeNonVisualProperties? _GroupShapeNonVisualProperties;
    /// <summary>
    ///   GroupShapeProperties.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.GroupShapeType.GroupShapeProperties))]
    /// <summary>
    ///   GroupShapeProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXOD.GroupShapeType))]
    public GroupShapeProperties? GroupShapeProperties { get => _GroupShapeProperties; set => UpdateField(ref _GroupShapeProperties, value, nameof(GroupShapeProperties)); }

    private GroupShapeProperties? _GroupShapeProperties;
}