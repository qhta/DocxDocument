namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Point.
/// </summary>
[OpenXmlType(typeof(DXDD.Point))]
public partial class Point : ModelElement<DXDD.Point>
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.ModelId))]
  public string? ModelId { get => _ModelId; set => UpdateField(ref _ModelId, value, nameof(ModelId)); }

  private string? _ModelId;
  /// <summary>
  ///   Point Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.Type))]
  public Point? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

  private Point? _Type;
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.ConnectionId))]
  public string? ConnectionId { get => _ConnectionId; set => UpdateField(ref _ConnectionId, value, nameof(ConnectionId)); }

  private string? _ConnectionId;
  /// <summary>
  ///   Property Set.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.PropertySet))]
  public PropertySet? PropertySet { get => _PropertySet; set => UpdateField(ref _PropertySet, value, nameof(PropertySet)); }

  private PropertySet? _PropertySet;
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.ShapeProperties))]
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  ///   Text Body.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.TextBody))]
  public TextBody? TextBody { get => _TextBody; set => UpdateField(ref _TextBody, value, nameof(TextBody)); }

  private TextBody? _TextBody;
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Point.PtExtensionList))]
  public PtExtensionList? PtExtensionList { get => _PtExtensionList; set => UpdateField(ref _PtExtensionList, value, nameof(PtExtensionList)); }

  private PtExtensionList? _PtExtensionList;
}