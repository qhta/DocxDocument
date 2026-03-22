namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CompatibilitySetting
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeUriString() => UriString is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
