namespace DocumentModel.Wordprocessing;

public partial class CompatibilitySetting
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeUriString() => UriString is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
