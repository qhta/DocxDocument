namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a collection of data labels.
///   This extension allows adding new properties or behaviors to data labels, such as advanced formatting or layout options.
/// </summary>
[OpenXmlType(typeof(DXDC.DLblExtension))]
public partial class DataLabelsExtension : Extension<DXDC.DLblExtension>
{
  /// <summary>
  ///   Chart Text, specifying the text content for the data labels extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.Layout))]
  public ChartText? ChartText { get => _ChartText; set => UpdateField(ref _ChartText, value, nameof(ChartText)); }

  private ChartText? _ChartText;
  /// <summary>
  ///   Data Label Field Table, defining custom fields for the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.DataLabelFieldTable))]
  public DataLabelFieldTable? DataLabelFieldTable { get => _DataLabelFieldTable; set => UpdateField(ref _DataLabelFieldTable, value, nameof(DataLabelFieldTable)); }

  private DataLabelFieldTable? _DataLabelFieldTable;
  /// <summary>
  ///   Indicates whether the data labels range is shown.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ShowDataLabelsRange))]
  public bool? ShowDataLabelsRange { get => _ShowDataLabelsRange; set => UpdateField(ref _ShowDataLabelsRange, value, nameof(ShowDataLabelsRange)); }

  private bool? _ShowDataLabelsRange;
  /// <summary>
  ///   Shape properties for the data labels extension.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ShapeProperties))]
  [OpenXmlType(typeof(DXO13DC.ShapeProperties))]
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  ///   Layout configuration for the data labels extension.
  /// </summary>
  [OpenXmlType(typeof(DXO13DC.Layout))]
  public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }

  private Layout? _Layout;
  /// <summary>
  ///   Indicates whether leader lines are shown.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ShapeProperties))]
  public bool? ShowLeaderLines { get => _ShowLeaderLines; set => UpdateField(ref _ShowLeaderLines, value, nameof(ShowLeaderLines)); }

  private bool? _ShowLeaderLines;
  /// <summary>
  ///   Leader lines configuration for the data labels.
  /// </summary>
  [OpenXmlIndirectElement(typeof(DXO13DC.LeaderLines), typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? LeaderLines { get => _LeaderLines; set => UpdateField(ref _LeaderLines, value, nameof(LeaderLines)); }

  private ChartShapeProperties? _LeaderLines;
}