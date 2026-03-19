namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Data Model.
/// </summary>
[OpenXmlType(typeof(DXDD.DataModel))]
public partial class DataModel : ModelElement<DXDD.DataModel>
{
  /// <summary>
  ///   Point List.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModel.PointList))]
  public PointList? PointList { get => _PointList; set => UpdateField(ref _PointList, value, nameof(PointList)); }

  private PointList? _PointList;
  /// <summary>
  ///   Connection List.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModel.ConnectionList))]
  public ConnectionList? ConnectionList { get => _ConnectionList; set => UpdateField(ref _ConnectionList, value, nameof(ConnectionList)); }

  private ConnectionList? _ConnectionList;
  /// <summary>
  ///   Background Formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModel.Background))]
  public Background? Background { get => _Background; set => UpdateField(ref _Background, value, nameof(Background)); }

  private Background? _Background;
  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModel.Whole))]
  public Whole? Whole { get => _Whole; set => UpdateField(ref _Whole, value, nameof(Whole)); }

  private Whole? _Whole;
  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModel.DataModelExtensionList))]
  public DataModelExtensionList? DataModelExtensionList { get => _DataModelExtensionList; set => UpdateField(ref _DataModelExtensionList, value, nameof(DataModelExtensionList)); }

  private DataModelExtensionList? _DataModelExtensionList;
}