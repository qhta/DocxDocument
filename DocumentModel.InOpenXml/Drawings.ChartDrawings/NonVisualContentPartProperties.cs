namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NonVisualContentPartProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO10DCD.NonVisualContentPartProperties))]
[XmlRoot("NonVisualContentPartProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class NonVisualContentPartProperties : ModelElement<DXO10DCD.NonVisualContentPartProperties>
{
 /// <summary>
 /// Specifies the non visual drawing properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualContentPartProperties.NonVisualDrawingProperties))]
 public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }
 private NonVisualDrawingProperties? _NonVisualDrawingProperties;

 /// <summary>
 /// Specifies the non visual ink content part properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.NonVisualContentPartProperties.NonVisualInkContentPartProperties))]
 public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get => _NonVisualInkContentPartProperties; set => UpdateField(ref _NonVisualInkContentPartProperties, value, nameof(NonVisualInkContentPartProperties)); }
 private NonVisualInkContentPartProperties? _NonVisualInkContentPartProperties;
}