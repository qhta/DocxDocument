namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.ShapeNonVisualProperties))]
[DataContract]
[XmlRoot("ShapeNonVisualProperties", Namespace = "DocumentModel.Drawings.Office")]
public partial class ShapeNonVisualProperties: ModelElement<DXOD.ShapeNonVisualProperties>
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.ShapeNonVisualProperties.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => _NonVisualDrawingProperties ??=
      GetProperty<NonVisualDrawingProperties?>(GetUpdatableElement()?.NonVisualDrawingProperties);
    set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties));
  }

  private NonVisualDrawingProperties? _NonVisualDrawingProperties;

  /// <summary>
  ///   NonVisualDrawingShapeProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.ShapeNonVisualProperties.NonVisualDrawingShapeProperties))]
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get => _NonVisualDrawingShapeProperties ??=
      GetProperty<NonVisualDrawingShapeProperties?>(GetUpdatableElement()?.NonVisualDrawingShapeProperties);
    set => UpdateField(ref _NonVisualDrawingShapeProperties, value, nameof(NonVisualDrawingShapeProperties));
  }

  private NonVisualDrawingShapeProperties? _NonVisualDrawingShapeProperties;
}