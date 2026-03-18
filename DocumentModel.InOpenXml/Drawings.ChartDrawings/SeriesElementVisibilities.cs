namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the SeriesElementVisibilities Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.SeriesElementVisibilities))]
public class SeriesElementVisibilities: ModelElement<DXO16DCD.SeriesElementVisibilities>
{
  /// <summary>
  /// Specifies the connector lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesElementVisibilities.ConnectorLines))]
  public bool? ConnectorLines
  {
    get => _ConnectorLines;
    set => UpdateField(ref _ConnectorLines, value, nameof(ConnectorLines));
  }

  private bool? _ConnectorLines;

  /// <summary>
  /// Specifies the mean line.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesElementVisibilities.MeanLine))]
  public bool? MeanLine { get => _MeanLine; set => UpdateField(ref _MeanLine, value, nameof(MeanLine)); }

  private bool? _MeanLine;

  /// <summary>
  /// Specifies the mean marker.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesElementVisibilities.MeanMarker))]
  public bool? MeanMarker { get => _MeanMarker; set => UpdateField(ref _MeanMarker, value, nameof(MeanMarker)); }

  private bool? _MeanMarker;

  /// <summary>
  /// Specifies the nonoutliers.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesElementVisibilities.Nonoutliers))]
  public bool? Nonoutliers { get => _Nonoutliers; set => UpdateField(ref _Nonoutliers, value, nameof(Nonoutliers)); }

  private bool? _Nonoutliers;

  /// <summary>
  /// Specifies the outliers.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesElementVisibilities.Outliers))]
  public bool? Outliers { get => _Outliers; set => UpdateField(ref _Outliers, value, nameof(Outliers)); }

  private bool? _Outliers;
}