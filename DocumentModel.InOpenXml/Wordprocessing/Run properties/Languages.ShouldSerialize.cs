namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Languages
{
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
  public bool ShouldSerializeBidi() => !String.IsNullOrEmpty(Bidi);
  public bool ShouldSerializeEastAsia() => !String.IsNullOrEmpty(EastAsia);
}
