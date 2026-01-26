namespace DocumentModel.Drawings;
/// <summary>
/// Represents an XY adjust handle, providing guides and limits for horizontal and vertical adjustments of a shape.
/// </summary>
[OpenXmlType(typeof(DXD.AdjustHandleXY))]
public partial class AdjustHandleXY : ModelElement<DXD.AdjustHandleXY>
{
 /// <summary>
 /// Horizontal adjustment guide, which determines how the X coordinate is adjusted.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.XAdjustmentGuide))]
 /// <summary>
 /// Horizontal adjustment guide, which determines how the X coordinate is adjusted.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? XAdjustmentGuide { get => _XAdjustmentGuide; set => UpdateField(ref _XAdjustmentGuide, value, nameof(XAdjustmentGuide)); }

 private string? _XAdjustmentGuide;
 /// <summary>
 /// Minimum allowed value for horizontal adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MinX))]
 /// <summary>
 /// Minimum allowed value for horizontal adjustment.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? MinX { get => _MinX; set => UpdateField(ref _MinX, value, nameof(MinX)); }

 private string? _MinX;
 /// <summary>
 /// Maximum allowed value for horizontal adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MaxX))]
 /// <summary>
 /// Maximum allowed value for horizontal adjustment.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? MaxX { get => _MaxX; set => UpdateField(ref _MaxX, value, nameof(MaxX)); }

 private string? _MaxX;
 /// <summary>
 /// Vertical adjustment guide, which determines how the Y coordinate is adjusted.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.YAdjustmentGuide))]
 /// <summary>
 /// Vertical adjustment guide, which determines how the Y coordinate is adjusted.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? YAdjustmentGuide { get => _YAdjustmentGuide; set => UpdateField(ref _YAdjustmentGuide, value, nameof(YAdjustmentGuide)); }

 private string? _YAdjustmentGuide;
 /// <summary>
 /// Minimum allowed value for vertical adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MinY))]
 /// <summary>
 /// Minimum allowed value for vertical adjustment.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? MinY { get => _MinY; set => UpdateField(ref _MinY, value, nameof(MinY)); }

 private string? _MinY;
 /// <summary>
 /// Maximum allowed value for vertical adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.MaxY))]
 /// <summary>
 /// Maximum allowed value for vertical adjustment.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public string? MaxY { get => _MaxY; set => UpdateField(ref _MaxY, value, nameof(MaxY)); }

 private string? _MaxY;
 /// <summary>
 /// Position of the adjust handle as a two-dimensional point.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AdjustHandleXY.Position))]
 /// <summary>
 /// Position of the adjust handle as a two-dimensional point.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AdjustHandleXY))]
 public AdjustPoint2DType? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private AdjustPoint2DType? _Position;
}