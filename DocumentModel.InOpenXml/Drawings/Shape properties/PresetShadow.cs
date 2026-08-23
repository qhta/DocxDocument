namespace DocumentModel.Drawings;

/// <summary>
///   Represents a preset shadow effect, including type, distance, direction, and color options.
/// </summary>
[OpenXmlType(typeof(DXD.PresetShadow))]
[DataContract]
[XmlRoot("PresetShadow", Namespace = "DocumentModel.Drawings")]
public partial class PresetShadow: ModelElement<DXD.PresetShadow>
{
  /// <summary>
  ///   Preset shadow type.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.PresetShadow.Preset))]
  public PresetShadows? Preset
  {
    get => _Preset ??= GetProperty<PresetShadows?>(GetUpdatableElement()?.Preset);
    set => UpdateField(ref _Preset, value, nameof(Preset));
  }

  private PresetShadows? _Preset;

  /// <summary>
  ///   Distance to offset the shadow from the object.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.PresetShadow.Distance))]
  public Int64? Distance
  {
    get => _Distance ??= GetProperty<Int64?>(GetUpdatableElement()?.Distance);
    set => UpdateField(ref _Distance, value, nameof(Distance));
  }

  private Int64? _Distance;

  /// <summary>
  ///   Direction angle of the shadow.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.PresetShadow.Direction))]
  public Int32? Direction
  {
    get => _Direction ??= GetProperty<Int32?>(GetUpdatableElement()?.Direction);
    set => UpdateField(ref _Direction, value, nameof(Direction));
  }

  private Int32? _Direction;

  /// <summary>
  ///   Shadow color specified using the RGB color model with percentage values.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.PresetShadow.RgbColorModelPercentage))]
  public ColorType? Color
  {
    get => _Color ??= GetProperty<ColorType?>(GetUpdatableElement()?.RgbColorModelPercentage);
    set => UpdateField(ref _Color, value, nameof(Color));
  }

  private ColorType? _Color;
}