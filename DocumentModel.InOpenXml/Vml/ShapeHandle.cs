namespace DocumentModel.Vml;
/// <summary>
///   Shape Handle.
/// </summary>
[OpenXmlType(typeof(DXV.ShapeHandle))]
[XmlRoot("ShapeHandle", Namespace = "DocumentModel.Vml")]
public partial class ShapeHandle : ModelElement<DXV.ShapeHandle>
{
 /// <summary>
 ///   Handle Position
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.Position))]
 public string? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

 private string? _Position;
 /// <summary>
 ///   Handle Polar Center
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.Polar))]
 public string? Polar { get => _Polar; set => UpdateField(ref _Polar, value, nameof(Polar)); }

 private string? _Polar;
 /// <summary>
 ///   Handle Coordinate Mapping
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.Map))]
 public string? Map { get => _Map; set => UpdateField(ref _Map, value, nameof(Map)); }

 private string? _Map;
 /// <summary>
 ///   Invert Handle's X Position
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.InvertX))]
 public bool? InvertX { get => _InvertX; set => UpdateField(ref _InvertX, value, nameof(InvertX)); }

 private bool? _InvertX;
 /// <summary>
 ///   Invert Handle's Y Position
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.InvertY))]
 public bool? InvertY { get => _InvertY; set => UpdateField(ref _InvertY, value, nameof(InvertY)); }

 private bool? _InvertY;
 /// <summary>
 ///   Handle Inversion Toggle
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.Switch))]
 public bool? Switch { get => _Switch; set => UpdateField(ref _Switch, value, nameof(Switch)); }

 private bool? _Switch;
 /// <summary>
 ///   Handle X Position Range
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.XRange))]
 public string? XRange { get => _XRange; set => UpdateField(ref _XRange, value, nameof(XRange)); }

 private string? _XRange;
 /// <summary>
 ///   Handle Y Position Range
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.YRange))]
 public string? YRange { get => _YRange; set => UpdateField(ref _YRange, value, nameof(YRange)); }

 private string? _YRange;
 /// <summary>
 ///   Handle Polar Radius Range
 /// </summary>
 [OpenXmlProperty(nameof(DXV.ShapeHandle.RadiusRange))]
 public string? RadiusRange { get => _RadiusRange; set => UpdateField(ref _RadiusRange, value, nameof(RadiusRange)); }

 private string? _RadiusRange;
}