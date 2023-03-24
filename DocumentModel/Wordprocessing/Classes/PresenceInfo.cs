namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PresenceInfo Class.
/// </summary>
public class PresenceInfo: ModelElement
{
  /// <summary>
  ///   providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ProviderId { get; set; }

  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? UserId { get; set; }
}