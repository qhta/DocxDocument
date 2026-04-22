namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the scaling properties for a category axis in a chart.
/// </summary>
/// <remarks>
///   This class defines the scaling configuration for category
///   axes, which display discrete data such as text labels, dates, or named categories. Unlike value axes
///   that represent continuous numeric data with minimum and maximum ranges, category axes organize data
///   into distinct, ordered categories. The primary scaling property for category axes is the gap width,
///   which controls the spacing between categories or groups of data. This is particularly relevant for
///   bar charts, column charts, and other visualizations where the spacing between categorical elements
///   affects both the visual appearance and data interpretation. Category axis scaling is used in conjunction
///   with the <see cref = "Axis"/> class, where either <c>CategoryAxisScaling</c> or <see cref = "ValueAxisScaling"/>
///   is specified depending on the axis type.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.CategoryAxisScaling))]
[XmlRoot("CategoryAxisScaling", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class CategoryAxisScaling : ModelElement<DXO16DCD.CategoryAxisScaling>
{
  /// <summary>
  /// Specifies the gap width.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.CategoryAxisScaling.GapWidth))]
  public string? GapWidth { get => _GapWidth; set => UpdateField(ref _GapWidth, value, nameof(GapWidth)); }

  private string? _GapWidth;
}