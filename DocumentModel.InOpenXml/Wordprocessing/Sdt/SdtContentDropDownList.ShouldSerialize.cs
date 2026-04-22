namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtContentDropDownList
{
  public bool ShouldSerializeLastValue() => !String.IsNullOrEmpty(LastValue);
}
