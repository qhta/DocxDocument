namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
public partial class ShapeNonVisualProperties : ModelElement<DXOD.ShapeNonVisualProperties>
{
    /// <summary>
    ///   NonVisualDrawingProperties.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    ///   NonVisualDrawingShapeProperties.
    /// </summary>
    public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get; set; }
}