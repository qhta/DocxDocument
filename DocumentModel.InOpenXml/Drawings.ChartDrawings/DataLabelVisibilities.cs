namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the visibility settings that control which components are displayed in data labels.
/// </summary>
/// <remarks>
///   This class defines visibility flags for different information
///   components that can be included in chart data labels. Data labels can display various types of information
///   to help users understand data points, including the series name, category name, and actual data value. This
///   class provides granular control over which components appear in labels, enabling customization based on
///   the chart's purpose and the information density desired. For example, a simple chart might show only values
///   to avoid clutter, while a complex multi-series chart might include series names to distinguish data points.
///   The visibility settings apply as defaults at the series level through <see cref = "DataLabels"/> or can be
///   customized for individual data points through <see cref = "DataLabel"/>. When multiple components are visible,
///   they are typically separated by the separator string defined in the parent data labels configuration. Common
///   configurations include showing only values for simple charts, combining values with category names for clarity,
///   or including all three components (series name, category name, and value) for comprehensive labeling in
///   complex visualizations. The visibility flags provide flexibility in balancing information richness with visual
///   clarity, allowing charts to be tailored to specific audiences and use cases.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.DataLabelVisibilities))]
[XmlRoot("DataLabelVisibilities", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class DataLabelVisibilities : ModelElement<DXO16DCD.DataLabelVisibilities>
{
 /// <summary>
 /// Specifies the series name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.DataLabelVisibilities.SeriesName))]
 public bool? SeriesName { get => _SeriesName; set => UpdateField(ref _SeriesName, value, nameof(SeriesName)); }

 private bool? _SeriesName;
 /// <summary>
 /// Specifies the category name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.DataLabelVisibilities.CategoryName))]
 public bool? CategoryName { get => _CategoryName; set => UpdateField(ref _CategoryName, value, nameof(CategoryName)); }

 private bool? _CategoryName;
 /// <summary>
 /// Specifies the value.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.DataLabelVisibilities.Value))]
 public bool? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

 private bool? _Value;
}