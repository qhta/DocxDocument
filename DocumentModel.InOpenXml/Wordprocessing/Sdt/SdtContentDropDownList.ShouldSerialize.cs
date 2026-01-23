namespace DocumentModel.Wordprocessing;

public partial class SdtContentDropDownList
{
  public bool ShouldSerializeLastValue() => LastValue is not null;
}
