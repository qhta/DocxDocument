namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents application-specific non-visual drawing properties for chart drawing elements.
/// </summary>
/// <remarks>
///   This class defines application-level properties
///   that affect the behavior and interaction of chart drawing objects but do not impact their visual
///   appearance. These properties include macro associations for interactive behavior and publication
///   status for content management. Non-visual properties are essential for defining the functional
///   characteristics of drawing elements beyond their graphical representation, enabling features such
///   as scripted interactions and document workflow management.
/// </remarks>
[OpenXmlType(typeof(DXO10DCD.ApplicationNonVisualDrawingProperties))]
[XmlRoot("ApplicationNonVisualDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class ApplicationNonVisualDrawingProperties : ModelElement<DXO10DCD.ApplicationNonVisualDrawingProperties>
{
 /// <summary>
 /// Specifies the macro.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.ApplicationNonVisualDrawingProperties.Macro))]
 public string? Macro { get => _Macro; set => UpdateField(ref _Macro, value, nameof(Macro)); }

 private string? _Macro;
 /// <summary>
 /// Specifies the published.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10DCD.ApplicationNonVisualDrawingProperties.Published))]
 public bool? Published { get => _Published; set => UpdateField(ref _Published, value, nameof(Published)); }

 private bool? _Published;
}