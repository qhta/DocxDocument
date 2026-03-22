namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SdtListItem
{
  public bool ShouldSerializeDisplayText() => DisplayText is not null;
  public bool ShouldSerializeValue() => Value is not null;
}
