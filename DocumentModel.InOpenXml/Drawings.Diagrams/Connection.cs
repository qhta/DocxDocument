namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Connection.
/// </summary>
[OpenXmlType(typeof(DXDD.Connection))]
public partial class Connection : ModelElement<DXDD.Connection>
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.ModelId))]
  public string? ModelId { get => _ModelId; set => UpdateField(ref _ModelId, value, nameof(ModelId)); }
  private string? _ModelId;
  /// <summary>
  ///   Point Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.Type))]
  public ConnectionType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
  private ConnectionType? _Type;
  /// <summary>
  ///   Source Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.SourceId))]
  public string? SourceId { get => _SourceId; set => UpdateField(ref _SourceId, value, nameof(SourceId)); }
  private string? _SourceId;
  /// <summary>
  ///   Destination Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.DestinationId))]
  public string? DestinationId { get => _DestinationId; set => UpdateField(ref _DestinationId, value, nameof(DestinationId)); }
  private string? _DestinationId;
  /// <summary>
  ///   Source Position
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.SourcePosition))]
  public UInt32? SourcePosition { get => _SourcePosition; set => UpdateField(ref _SourcePosition, value, nameof(SourcePosition)); }
  private UInt32? _SourcePosition;
  /// <summary>
  ///   Destination Position
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.DestinationPosition))]
  public UInt32? DestinationPosition { get => _DestinationPosition; set => UpdateField(ref _DestinationPosition, value, nameof(DestinationPosition)); }
  private UInt32? _DestinationPosition;
  /// <summary>
  ///   Parent Transition Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.ParentTransitionId))]
  public string? ParentTransitionId { get => _ParentTransitionId; set => UpdateField(ref _ParentTransitionId, value, nameof(ParentTransitionId)); }
  private string? _ParentTransitionId;
  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.SiblingTransitionId))]
  public string? SiblingTransitionId { get => _SiblingTransitionId; set => UpdateField(ref _SiblingTransitionId, value, nameof(SiblingTransitionId)); }
  private string? _SiblingTransitionId;
  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.PresentationId))]
  public string? PresentationId { get => _PresentationId; set => UpdateField(ref _PresentationId, value, nameof(PresentationId)); }
  private string? _PresentationId;
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Connection.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}