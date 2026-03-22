namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SdtPlaceholder
{
  public bool ShouldSerializeDocPartReference() => DocPartReference is not null;
}
