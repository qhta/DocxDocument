namespace DocumentModel.Wordprocessing;

public partial class PresenceInfo
{
  public bool ShouldSerializeProviderId() => ProviderId is not null;
  public bool ShouldSerializeUserId() => UserId is not null;
}
