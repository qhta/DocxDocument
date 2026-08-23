namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents presence information for a user in a WordprocessingML document.
/// This class provides properties for the provider and user identifiers, enabling tracking and management of user presence and collaboration metadata.
/// </summary>
[OpenXmlType(typeof(DXO13W.PresenceInfo))]
[DataContract]
[XmlRoot("PresenceInfo", Namespace = "DocumentModel.Wordprocessing")]
public partial class PresenceInfo: ModelElement<DXO13W.PresenceInfo>
{
  /// <summary>
  /// Identifier for the presence provider, specifying the source of presence information.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13W.PresenceInfo.ProviderId))]
  public string? ProviderId
  {
    get => _ProviderId ??= GetProperty<string?>(GetUpdatableElement()?.ProviderId);
    set => UpdateField(ref _ProviderId, value, nameof(ProviderId));
  }

  private string? _ProviderId;

  /// <summary>
  /// Identifier for the user whose presence is being tracked.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13W.PresenceInfo.UserId))]
  public string? UserId
  {
    get => _UserId ??= GetProperty<string?>(GetUpdatableElement()?.UserId);
    set => UpdateField(ref _UserId, value, nameof(UserId));
  }

  private string? _UserId;
}