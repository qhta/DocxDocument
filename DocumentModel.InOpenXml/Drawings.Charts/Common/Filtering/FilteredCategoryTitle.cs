namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered category title for a chart, including the axis data source type.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredCategoryTitle))]
public partial class FilteredCategoryTitle: ModelElement<DXO13DC.FilteredCategoryTitle>
{
  /// <summary>
  ///   Axis data source type associated with the filtered category title.
  /// </summary>
  public AxisDataSourceType3? AxisDataSourceType
  {
    get => _AxisDataSourceType;
    set => UpdateField(ref _AxisDataSourceType, value, nameof(AxisDataSourceType));
  }

  private AxisDataSourceType3? _AxisDataSourceType;
}