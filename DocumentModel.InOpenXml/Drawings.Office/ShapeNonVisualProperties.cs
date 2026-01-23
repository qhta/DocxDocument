namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
public partial class ShapeNonVisualProperties : ModelElement<DXOD.ShapeNonVisualProperties>
{
    /// <summary>
    ///   NonVisualDrawingProperties.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.ShapeNonVisualProperties.NonVisualDrawingProperties))]
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    ///   NonVisualDrawingShapeProperties.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.ShapeNonVisualProperties.NonVisualDrawingShapeProperties))]
    public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get => _NonVisualDrawingShapeProperties; set => UpdateField(ref _NonVisualDrawingShapeProperties, value, nameof(NonVisualDrawingShapeProperties)); }

    private NonVisualDrawingShapeProperties? _NonVisualDrawingShapeProperties;
}