namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShapeNonVisualProperties))]
[XmlRoot("GroupShapeNonVisualProperties", Namespace = "DocumentModel.Drawings.Office")]
public partial class GroupShapeNonVisualProperties : ModelElement<DXOD.GroupShapeNonVisualProperties>
{
 /// <summary>
 ///   NonVisualDrawingProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeNonVisualProperties.NonVisualDrawingProperties))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }
 private NonVisualDrawingProperties? _NonVisualDrawingProperties;

 /// <summary>
 ///   NonVisualGroupDrawingShapeProperties.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeNonVisualProperties.NonVisualGroupDrawingShapeProperties))]
 public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get => _NonVisualGroupDrawingShapeProperties; set => UpdateField(ref _NonVisualGroupDrawingShapeProperties, value, nameof(NonVisualGroupDrawingShapeProperties)); }
 private NonVisualGroupDrawingShapeProperties? _NonVisualGroupDrawingShapeProperties;
}