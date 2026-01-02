namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Series Class.
/// </summary>
public class Series: ModelElement
{
  /// <summary>
  ///   layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId { get; set; }
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Hidden { get; set; }
  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx { get; set; }
  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
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