namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a single string data point in a chart.
/// </summary>
[OpenXmlType(typeof(DXDC.StringPoint))]
public partial class StringPoint : ModelElement<DXDC.StringPoint>
{
  /// <summary>
  ///   Index of the string point within the collection.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.StringPoint.Index))]
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private UInt32? _Index;

  /// <summary>
  ///   Text value of the string point.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.StringPoint.NumericValue))]
  public string? NumericValue { get => _NumericValue; set => UpdateField(ref _NumericValue, value, nameof(NumericValue)); }

  private string? _NumericValue;
}