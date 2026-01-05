namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Series Class.
/// </summary>
public interface Series:
{
  /// <summary>
  ///   layoutId
  /// </summary>
  public SeriesLayout? LayoutId { get; set; }
  /// <summary>
  ///   hidden
  /// </summary>
  public bool? Hidden { get; set; }
  /// <summary>
  ///   ownerIdx
  /// </summary>
  public UInt32? OwnerIdx { get; set; }
  /// <summary>
  ///   uniqueId
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   formatIdx
  /// </summary>
  public UInt32? FormatIdx { get; set; }
  /// <summary>
  ///   Text.
  /// </summary>
  public Text? Text { get; set; }
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   ValueColors.
  /// </summary>
  public ValueColors? ValueColors { get; set; }
  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  public ValueColorPositions? ValueColorPositions { get; set; }
  public Collection<DataPoint>? DataPoints { get; set; }
  public DataLabels? DataLabels { get; set; }
  public UInt32? DataId { get; set; }
  public SeriesLayoutProperties? SeriesLayoutProperties { get; set; }
  public Collection<String>? AxisIds { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}