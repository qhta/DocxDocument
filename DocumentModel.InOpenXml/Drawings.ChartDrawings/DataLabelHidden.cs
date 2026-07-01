namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a hidden data label indicator for a specific data point in a chart.
/// </summary>
/// <remarks>
///   This class defines a marker that identifies a data point
///   whose label should be hidden or suppressed in the chart visualization. While charts may have default
///   settings to display labels for all data points or series-wide label settings, the DataLabelHidden
///   class enables selective suppression of labels for specific data points identified by their index.
///   This is particularly useful when most data points in a series should show labels, but certain points
///   (such as outliers, zero values, or intermediate values) should not display labels to reduce clutter
///   or improve readability. The hidden label marker works in conjunction with the <see cref = "DataLabel"/>
///   class, where DataLabel defines visible labels with full formatting options, while DataLabelHidden
///   provides a lightweight indicator for suppressed labels. This selective hiding approach offers fine-grained
///   control over label visibility without requiring individual DataLabel definitions for every data point.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.DataLabelHidden))]
[DataContract]
[XmlRoot("DataLabelHidden", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class DataLabelHidden : ModelElement<DXO16DCD.DataLabelHidden>
{
  /// <summary>
  /// Specifies the idx.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabelHidden.Idx))]
  public UInt32? Idx { get => _Idx; set => UpdateField(ref _Idx, value, nameof(Idx)); }

  private UInt32? _Idx;
}