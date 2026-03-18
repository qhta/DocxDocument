namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a single data label.
///   This extension allows custom properties for individual data labels.
/// </summary>
[OpenXmlType(typeof(DXDC.DLblExtension))]
public partial class DataLabelExtension: Extension<DXDC.DLblExtension>
{
  /// <summary>
  ///   Data Label Field Table, defining custom fields for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.DataLabelFieldTable))]
  public DataLabelFieldTable? DataLabelFieldTable
  {
    get => _DataLabelFieldTable;
    set => UpdateField(ref _DataLabelFieldTable, value, nameof(DataLabelFieldTable));
  }

  private DataLabelFieldTable? _DataLabelFieldTable;

  /// <summary>
  ///   Indicates whether there is an exception for saving.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ExceptionForSave))]
  public bool? ExceptionForSave
  {
    get => _ExceptionForSave;
    set => UpdateField(ref _ExceptionForSave, value, nameof(ExceptionForSave));
  }

  private bool? _ExceptionForSave;

  /// <summary>
  ///   Indicates whether the data labels range is shown.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ShowDataLabelsRange))]
  public bool? ShowDataLabelsRange
  {
    get => _ShowDataLabelsRange;
    set => UpdateField(ref _ShowDataLabelsRange, value, nameof(ShowDataLabelsRange));
  }

  private bool? _ShowDataLabelsRange;

  /// <summary>
  ///   Shape properties for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  ///   Layout configuration for the data label.
  /// </summary>
  [OpenXmlType(typeof(DXO13DC.Layout))]

  /// <summary>
  ///   Layout configuration for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.Layout))]
  public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }

  private Layout? _Layout;
}