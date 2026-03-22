namespace DocumentModel.Drawings.ChartDrawing;
/// <summary>
/// Describes a marker type in chart drawings, including relative X and Y coordinate settings for positioning within the drawing canvas.
/// </summary>
[OpenXmlType(typeof(DXDCD.MarkerType))]
public class MarkerType<T>: ModelElement<DXDCD.MarkerType>
  where T: DXDCD.MarkerType
{
  /// <summary>
  /// Relative horizontal coordinate for positioning the marker.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.XPosition))]
  public string? XPosition { get => _XPosition; set => UpdateField(ref _XPosition, value, nameof(XPosition)); }
  private string? _XPosition;
  /// <summary>
  /// Relative vertical coordinate for positioning the marker.
  /// </summary>
  [OpenXmlElement(typeof(DXDCD.YPosition))]
  public string? YPosition { get => _YPosition; set => UpdateField(ref _YPosition, value, nameof(YPosition)); }
  private string? _YPosition;
}