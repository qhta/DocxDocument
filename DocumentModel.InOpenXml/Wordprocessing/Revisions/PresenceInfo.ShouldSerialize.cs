namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PresenceInfo
{
  public bool ShouldSerializeProviderId() => !String.IsNullOrEmpty(ProviderId);
  public bool ShouldSerializeUserId() => !String.IsNullOrEmpty(UserId);
}
