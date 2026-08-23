namespace DocumentModel.Vml;

/// <summary>
///   Shape Handle.
/// </summary>
[OpenXmlType(typeof(DXV.ShapeHandle))]
[DataContract]
[XmlRoot("ShapeHandle", Namespace = "DocumentModel.Vml")]
public partial class ShapeHandle: ModelElement<DXV.ShapeHandle>
{
  /// <summary>
  ///   Handle Position
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.Position))]
  public string? Position
  {
    get => _Position ??= GetProperty<string?>(GetUpdatableElement()?.Position);
    set => UpdateField(ref _Position, value, nameof(Position));
  }

  private string? _Position;

  /// <summary>
  ///   Handle Polar Center
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.Polar))]
  public string? Polar
  {
    get => _Polar ??= GetProperty<string?>(GetUpdatableElement()?.Polar);
    set => UpdateField(ref _Polar, value, nameof(Polar));
  }

  private string? _Polar;

  /// <summary>
  ///   Handle Coordinate Mapping
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.Map))]
  public string? Map
  {
    get => _Map ??= GetProperty<string?>(GetUpdatableElement()?.Map);
    set => UpdateField(ref _Map, value, nameof(Map));
  }

  private string? _Map;

  /// <summary>
  ///   Invert Handle's X Position
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.InvertX))]
  public bool? InvertX
  {
    get => _InvertX ??= GetProperty<bool?>(GetUpdatableElement()?.InvertX);
    set => UpdateField(ref _InvertX, value, nameof(InvertX));
  }

  private bool? _InvertX;

  /// <summary>
  ///   Invert Handle's Y Position
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.InvertY))]
  public bool? InvertY
  {
    get => _InvertY ??= GetProperty<bool?>(GetUpdatableElement()?.InvertY);
    set => UpdateField(ref _InvertY, value, nameof(InvertY));
  }

  private bool? _InvertY;

  /// <summary>
  ///   Handle Inversion Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.Switch))]
  public bool? Switch
  {
    get => _Switch ??= GetProperty<bool?>(GetUpdatableElement()?.Switch);
    set => UpdateField(ref _Switch, value, nameof(Switch));
  }

  private bool? _Switch;

  /// <summary>
  ///   Handle X Position Range
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.XRange))]
  public string? XRange
  {
    get => _XRange ??= GetProperty<string?>(GetUpdatableElement()?.XRange);
    set => UpdateField(ref _XRange, value, nameof(XRange));
  }

  private string? _XRange;

  /// <summary>
  ///   Handle Y Position Range
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.YRange))]
  public string? YRange
  {
    get => _YRange ??= GetProperty<string?>(GetUpdatableElement()?.YRange);
    set => UpdateField(ref _YRange, value, nameof(YRange));
  }

  private string? _YRange;

  /// <summary>
  ///   Handle Polar Radius Range
  /// </summary>
  [OpenXmlProperty(nameof(DXV.ShapeHandle.RadiusRange))]
  public string? RadiusRange
  {
    get => _RadiusRange ??= GetProperty<string?>(GetUpdatableElement()?.RadiusRange);
    set => UpdateField(ref _RadiusRange, value, nameof(RadiusRange));
  }

  private string? _RadiusRange;
}