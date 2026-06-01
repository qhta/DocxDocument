namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PresenceInfo Class.
/// </summary>
public class PresenceInfo: ModelElement
{
  /// <summary>
  ///   providerId, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? ProviderId { get; set; }

  /// <summary>
  ///   userId, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? UserId { get; set; }
}
