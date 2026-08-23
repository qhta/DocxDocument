namespace DocumentModel;

/// <summary>
///   Defines the ClassificationLabel Class.
/// </summary>
[OpenXmlType(typeof(DXO21MLMD.ClassificationLabel))]
[DataContract]
[XmlRoot("ClassificationLabel", Namespace = "DocumentModel")]
public partial class ClassificationLabel: ModelElement<DXO21MLMD.ClassificationLabel>
{
  /// <summary>
  ///   id
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   enabled
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Enabled))]
  public bool? Enabled
  {
    get => _Enabled ??= GetProperty<bool?>(GetUpdatableElement()?.Enabled);
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }

  private bool? _Enabled;

  /// <summary>
  ///   setDate
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.SetDate))]
  public string? SetDate
  {
    get => _SetDate ??= GetProperty<string?>(GetUpdatableElement()?.SetDate);
    set => UpdateField(ref _SetDate, value, nameof(SetDate));
  }

  private string? _SetDate;

  /// <summary>
  ///   method
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Method))]
  public string? Method
  {
    get => _Method ??= GetProperty<string?>(GetUpdatableElement()?.Method);
    set => UpdateField(ref _Method, value, nameof(Method));
  }

  private string? _Method;

  /// <summary>
  ///   name
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Name))]
  public string? Name
  {
    get => _Name ??= GetProperty<string?>(GetUpdatableElement()?.Name);
    set => UpdateField(ref _Name, value, nameof(Name));
  }

  private string? _Name;

  /// <summary>
  ///   siteId
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.SiteId))]
  public string? SiteId
  {
    get => _SiteId ??= GetProperty<string?>(GetUpdatableElement()?.SiteId);
    set => UpdateField(ref _SiteId, value, nameof(SiteId));
  }

  private string? _SiteId;

  /// <summary>
  ///   actionId
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.ActionId))]
  public string? ActionId
  {
    get => _ActionId ??= GetProperty<string?>(GetUpdatableElement()?.ActionId);
    set => UpdateField(ref _ActionId, value, nameof(ActionId));
  }

  private string? _ActionId;

  /// <summary>
  ///   contentBits
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.ContentBits))]
  public UInt32? ContentBits
  {
    get => _ContentBits ??= GetProperty<UInt32?>(GetUpdatableElement()?.ContentBits);
    set => UpdateField(ref _ContentBits, value, nameof(ContentBits));
  }

  private UInt32? _ContentBits;

  /// <summary>
  ///   removed
  /// </summary>
  [OpenXmlProperty(nameof(DXO21MLMD.ClassificationLabel.Removed))]
  public bool? Removed
  {
    get => _Removed ??= GetProperty<bool?>(GetUpdatableElement()?.Removed);
    set => UpdateField(ref _Removed, value, nameof(Removed));
  }

  private bool? _Removed;
}