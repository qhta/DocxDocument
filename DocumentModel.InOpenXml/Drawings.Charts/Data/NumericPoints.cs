namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a numeric data point in a chart.
/// </summary>
[OpenXmlType(typeof(DXDC.NumericPoint))]
[DataContract]
[XmlRoot("NumericPoints", Namespace = "DocumentModel.Drawings.Charts")]
public partial class NumericPoints: ModelElement<DXDC.NumericPoint>
{
  /// <summary>
  ///   Index of the numeric point.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumericPoint.Index))]
  public UInt32? Index
  {
    get => _Index ??= GetProperty<UInt32?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Format code for the numeric value.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumericPoint.FormatCode))]
  public string? FormatCode
  {
    get => _FormatCode ??= GetProperty<string?>(GetUpdatableElement()?.FormatCode);
    set => UpdateField(ref _FormatCode, value, nameof(FormatCode));
  }

  private string? _FormatCode;

  /// <summary>
  ///   Numeric value of the point.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumericPoint.NumericValue))]
  public string? NumericValue
  {
    get => _NumericValue ??= GetProperty<string?>(GetUpdatableElement()?.NumericValue);
    set => UpdateField(ref _NumericValue, value, nameof(NumericValue));
  }

  private string? _NumericValue;
}