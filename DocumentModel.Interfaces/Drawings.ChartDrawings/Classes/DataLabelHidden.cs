namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a hidden data label indicator for a specific data point in a chart.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a marker that identifies a data point
///   whose label should be hidden or suppressed in the chart visualization. While charts may have default
///   settings to display labels for all data points or series-wide label settings, the DataLabelHidden
///   interface enables selective suppression of labels for specific data points identified by their index.
///   This is particularly useful when most data points in a series should show labels, but certain points
///   (such as outliers, zero values, or intermediate values) should not display labels to reduce clutter
///   or improve readability. The hidden label marker works in conjunction with the <see cref="DataLabel"/>
///   interface, where DataLabel defines visible labels with full formatting options, while DataLabelHidden
///   provides a lightweight indicator for suppressed labels. This selective hiding approach offers fine-grained
///   control over label visibility without requiring individual DataLabel definitions for every data point.
///   This functionality is available in Office 2016 and later versions.
/// </remarks>
public interface DataLabelHidden : IModelElement
{
  /// <summary>
  ///   Gets or sets the zero-based index identifying which data point's label should be hidden.
  /// </summary>
  /// <value>
  ///   An unsigned 32-bit integer representing the data point index,
  ///   or <c>null</c> if no index is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The index identifies a specific data point in the series whose label should be suppressed from
  ///   display. The index is zero-based, meaning the first data point has index 0, the second has index 1,
  ///   and so on. This enables precise control over which data points do not display labels, even when
  ///   the series or chart has a general setting to show labels. Common scenarios include hiding labels
  ///   for data points with zero or null values, hiding labels for middle data points in a dense series
  ///   to reduce clutter while keeping labels on key points (minimum, maximum, first, last), or suppressing
  ///   labels for outliers that might distort the visual layout.
  /// </remarks>
  public UInt32? Idx { get; set; }
}