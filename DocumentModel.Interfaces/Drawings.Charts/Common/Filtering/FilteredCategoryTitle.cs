namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered category title for a chart, including the axis data source type.
/// </summary>
public interface FilteredCategoryTitle
{
  /// <summary>
  ///   Axis data source type associated with the filtered category title.
  /// </summary>
  public AxisDataSourceType3 AxisDataSourceType { get; set; }
}