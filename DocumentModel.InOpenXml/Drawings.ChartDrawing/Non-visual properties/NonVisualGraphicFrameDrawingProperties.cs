namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes non-visual properties for a graphic frame in chart drawings, including locking options that restrict editing or manipulation of the frame.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualGraphicFrameDrawingProperties))]
[XmlRoot("NonVisualGraphicFrameDrawingProperties", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public class NonVisualGraphicFrameDrawingProperties : ModelElement<DXDCD.NonVisualGraphicFrameDrawingProperties> //, IExtendableElement
{
 /// <summary>
 /// Specifies locking options for the graphic frame to control editing and manipulation.
 /// </summary>
 [OpenXmlProperty(nameof(DXDCD.NonVisualGraphicFrameDrawingProperties.GraphicFrameLocks))]
 public GraphicFrameLocks? GraphicFrameLocks { get => _GraphicFrameLocks; set => UpdateField(ref _GraphicFrameLocks, value, nameof(GraphicFrameLocks)); }
 private GraphicFrameLocks? _GraphicFrameLocks;
}