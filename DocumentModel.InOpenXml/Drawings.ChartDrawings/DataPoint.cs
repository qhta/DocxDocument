namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a single data point in a chart series with customizable visual formatting.
/// </summary>
/// <remarks>
///   This class defines an individual data point within a chart series
///   that can have its own unique visual styling separate from the series' default formatting. Data points are the
///   fundamental building blocks of chart visualizations, representing individual values or observations in the data.
///   While most data points inherit formatting from their parent series, this class enables selective customization
///   of specific points to emphasize outliers, highlight important values, or visually distinguish particular observations.
///   Each data point is identified by its zero-based index within the series, corresponding to its position in the
///   data sequence. The <see cref = "ShapeProperties"/> allow override of the series' default visual styling with
///   custom fill, line, effects, and other formatting specific to this point. This is particularly valuable for
///   drawing attention to key data points such as maximum or minimum values, target thresholds, anomalies, or data
///   points that require special emphasis in presentations or reports. Common use cases include highlighting the
///   highest sales month in a different color, marking data points that exceed targets, distinguishing negative values,
///   or emphasizing trend changes. The data point customization works in conjunction with <see cref = "DataLabel"/> and
///   <see cref = "DataLabelHidden"/> to control both the visual appearance and labeling of individual points. Extension
///   support enables future enhancements to data point functionality without schema changes.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.DataPoint))]
[DataContract]
[XmlRoot("DataPoint", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class DataPoint : ModelElement<DXO16DCD.DataPoint>
{
  /// <summary>
  /// Specifies the idx.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataPoint.Idx))]
  public UInt32? Idx { get => _Idx; set => UpdateField(ref _Idx, value, nameof(Idx)); }

  private UInt32? _Idx;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataPoint.ShapeProperties))]
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataPoint.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}