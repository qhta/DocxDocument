namespace DocumentModel.Drawings;

/// <summary>
/// Represents a polar adjust handle, providing guides and limits for radial and angular adjustments of a shape.
/// </summary>
[OpenXmlType(typeof(DXD.AdjustHandlePolar))]
[DataContract]
[XmlRoot("AdjustHandlePolar", Namespace = "DocumentModel.Drawings")]
public partial class AdjustHandlePolar: ModelElement<DXD.AdjustHandlePolar>
{
  /// <summary>
  /// Radial adjustment guide, which determines how the radial distance is adjusted.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.RadialAdjustmentGuide))]
  public string? RadialAdjustmentGuide
  {
    get => _RadialAdjustmentGuide ??= GetProperty<string?>(GetUpdatableElement()?.RadialAdjustmentGuide);
    set => UpdateField(ref _RadialAdjustmentGuide, value, nameof(RadialAdjustmentGuide));
  }
  private string? _RadialAdjustmentGuide;

  /// <summary>
  /// Minimum allowed value for radial adjustment.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.MinRadial))]
  public string? MinRadial
  {
    get => _MinRadial ??= GetProperty<string?>(GetUpdatableElement()?.MinRadial);
    set => UpdateField(ref _MinRadial, value, nameof(MinRadial));
  }
  private string? _MinRadial;

  /// <summary>
  /// Maximum allowed value for radial adjustment.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.MaxRadial))]
  public string? MaxRadial
  {
    get => _MaxRadial ??= GetProperty<string?>(GetUpdatableElement()?.MaxRadial);
    set => UpdateField(ref _MaxRadial, value, nameof(MaxRadial));
  }
  private string? _MaxRadial;

  /// <summary>
  /// Angle adjustment guide, which determines how the angle is adjusted.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.AngleAdjustmentGuide))]
  public string? AngleAdjustmentGuide
  {
    get => _AngleAdjustmentGuide ??= GetProperty<string?>(GetUpdatableElement()?.AngleAdjustmentGuide);
    set => UpdateField(ref _AngleAdjustmentGuide, value, nameof(AngleAdjustmentGuide));
  }
  private string? _AngleAdjustmentGuide;

  /// <summary>
  /// Minimum allowed value for angle adjustment.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.MinAngle))]
  public string? MinAngle
  {
    get => _MinAngle ??= GetProperty<string?>(GetUpdatableElement()?.MinAngle);
    set => UpdateField(ref _MinAngle, value, nameof(MinAngle));
  }
  private string? _MinAngle;

  /// <summary>
  /// Maximum allowed value for angle adjustment.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.MaxAngle))]
  public string? MaxAngle
  {
    get => _MaxAngle ??= GetProperty<string?>(GetUpdatableElement()?.MaxAngle);
    set => UpdateField(ref _MaxAngle, value, nameof(MaxAngle));
  }
  private string? _MaxAngle;

  /// <summary>
  /// Position of the adjust handle as a two-dimensional coordinate.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AdjustHandlePolar.Position))]
  public AdjustPoint2DType? Position
  {
    get => _Position ??= GetProperty<AdjustPoint2DType?>(GetUpdatableElement()?.Position);
    set => UpdateField(ref _Position, value, nameof(Position));
  }
  private AdjustPoint2DType? _Position;
}