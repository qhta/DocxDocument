namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtListItem
{
  public bool ShouldSerializeDisplayText() => !String.IsNullOrEmpty(DisplayText);
  public bool ShouldSerializeValue() => !String.IsNullOrEmpty(Value);
}
