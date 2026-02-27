namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Languages
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeBidi() => Bidi is not null;
  public bool ShouldSerializeEastAsia() => EastAsia is not null;
}
