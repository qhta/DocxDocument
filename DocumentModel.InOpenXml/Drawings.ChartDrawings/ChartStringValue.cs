namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a string value associated with a specific index position in chart data.
/// </summary>
/// <remarks>
///   This class defines a string value element that is positioned
///   at a specific index within a chart data series or category collection. Chart string values are typically
///   used for category labels, data point labels, or series names that need to be associated with a particular
///   position in the data structure. The index-based approach allows for sparse data representations where not
///   every position needs a value, and enables explicit ordering of string values regardless of insertion order.
///   This is particularly useful in chart scenarios where string labels need to align with specific data points
///   or categories, such as custom category names, data point annotations, or series identifiers. The indexed
///   structure supports efficient lookup and modification of string values at specific positions within the
///   chart's data model.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ChartStringValue))]
[XmlRoot("ChartStringValue", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ChartStringValue : ModelElement<DXO16DCD.ChartStringValue>
{
  /// <summary>
  /// Specifies the index.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartStringValue.Index))]
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private UInt32? _Index;
}