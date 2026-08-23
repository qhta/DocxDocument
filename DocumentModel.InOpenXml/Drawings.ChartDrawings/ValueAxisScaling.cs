namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueAxisScaling Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ValueAxisScaling))]
[DataContract]
[XmlRoot("ValueAxisScaling", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ValueAxisScaling: ModelElement<DXO16DCD.ValueAxisScaling>
{
  /// <summary>
  /// Specifies the max.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueAxisScaling.Max))]
  public string? Max
  {
    get => _Max ??= GetProperty<string?>(GetUpdatableElement()?.Max);
    set => UpdateField(ref _Max, value, nameof(Max));
  }

  private string? _Max;

  /// <summary>
  /// Specifies the min.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueAxisScaling.Min))]
  public string? Min
  {
    get => _Min ??= GetProperty<string?>(GetUpdatableElement()?.Min);
    set => UpdateField(ref _Min, value, nameof(Min));
  }

  private string? _Min;

  /// <summary>
  /// Specifies the major unit.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueAxisScaling.MajorUnit))]
  public string? MajorUnit
  {
    get => _MajorUnit ??= GetProperty<string?>(GetUpdatableElement()?.MajorUnit);
    set => UpdateField(ref _MajorUnit, value, nameof(MajorUnit));
  }

  private string? _MajorUnit;

  /// <summary>
  /// Specifies the minor unit.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ValueAxisScaling.MinorUnit))]
  public string? MinorUnit
  {
    get => _MinorUnit ??= GetProperty<string?>(GetUpdatableElement()?.MinorUnit);
    set => UpdateField(ref _MinorUnit, value, nameof(MinorUnit));
  }

  private string? _MinorUnit;
}