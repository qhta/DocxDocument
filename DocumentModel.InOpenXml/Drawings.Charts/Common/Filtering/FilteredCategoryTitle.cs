namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a filtered category title for a chart, including the axis data source type.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FilteredCategoryTitle))]
[DataContract]
[XmlRoot("FilteredCategoryTitle", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FilteredCategoryTitle : ModelElement<DXO13DC.FilteredCategoryTitle>
{
 /// <summary>
 ///   Axis data source type associated with the filtered category title.
 /// </summary>
 [OpenXmlType(typeof(DXO13DC.AxisDataSourceType))]
 public AxisDataSourceType? AxisDataSourceType { get => _AxisDataSourceType; set => UpdateField(ref _AxisDataSourceType, value, nameof(AxisDataSourceType)); }
 private AxisDataSourceType? _AxisDataSourceType;
}