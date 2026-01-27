namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PresenceInfo
{
  public bool ShouldSerializeProviderId() => ProviderId is not null;
  public bool ShouldSerializeUserId() => UserId is not null;
}
