namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Data Model.
/// </summary>
[OpenXmlType(typeof(DXDD.DataModelRoot))]
[DataContract]
[XmlRoot("DataModelRoot", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class DataModelRoot: ModelElement<DXDD.DataModelRoot>
{
  /// <summary>
  ///   Point List.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModelRoot.PointList))]
  public PointList? PointList
  {
    get => _PointList ??= GetProperty<PointList?>(GetUpdatableElement()?.PointList);
    set => UpdateField(ref _PointList, value, nameof(PointList));
  }

  private PointList? _PointList;

  /// <summary>
  ///   Connection List.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModelRoot.ConnectionList))]
  public ConnectionList? ConnectionList
  {
    get => _ConnectionList ??= GetProperty<ConnectionList?>(GetUpdatableElement()?.ConnectionList);
    set => UpdateField(ref _ConnectionList, value, nameof(ConnectionList));
  }

  private ConnectionList? _ConnectionList;

  /// <summary>
  ///   Background Formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModelRoot.Background))]
  public Background? Background
  {
    get => _Background ??= GetProperty<Background?>(GetUpdatableElement()?.Background);
    set => UpdateField(ref _Background, value, nameof(Background));
  }

  private Background? _Background;

  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModelRoot.Whole))]
  public Whole? Whole
  {
    get => _Whole ??= GetProperty<Whole?>(GetUpdatableElement()?.Whole);
    set => UpdateField(ref _Whole, value, nameof(Whole));
  }

  private Whole? _Whole;

  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.DataModelRoot.DataModelExtensionList))]
  public DataModelExtensionList? DataModelExtensionList
  {
    get => _DataModelExtensionList ??=
      GetProperty<DataModelExtensionList?>(GetUpdatableElement()?.DataModelExtensionList);
    set => UpdateField(ref _DataModelExtensionList, value, nameof(DataModelExtensionList));
  }

  private DataModelExtensionList? _DataModelExtensionList;
}