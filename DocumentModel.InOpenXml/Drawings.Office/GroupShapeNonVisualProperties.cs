namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public partial class GroupShapeNonVisualProperties : ModelElement<DXOD.GroupShapeNonVisualProperties>
{
    /// <summary>
    ///   NonVisualDrawingProperties.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    ///   NonVisualGroupDrawingShapeProperties.
    /// </summary>
    public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
}