namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a shape in chart drawings, including text box indication, locking options, and extension data.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualShapeDrawingProperties))]
[DataContract]
[XmlRoot("NonVisualShapeDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class NonVisualShapeDrawingProperties : ModelElement<DXDCD.NonVisualShapeDrawingProperties> //: ExtendableElement
{
  /// <summary>
  /// Indicates whether the shape functions as a text box within the drawing.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualShapeDrawingProperties.TextBox))]
  public bool? TextBox { get => _TextBox; set => UpdateField(ref _TextBox, value, nameof(TextBox)); }

  private bool? _TextBox;
  /// <summary>
  /// Specifies locking options that restrict editing or manipulation of the shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualShapeDrawingProperties.ShapeLocks))]
  public ShapeLocks? ShapeLocks { get => _ShapeLocks; set => UpdateField(ref _ShapeLocks, value, nameof(ShapeLocks)); }

  private ShapeLocks? _ShapeLocks;
}