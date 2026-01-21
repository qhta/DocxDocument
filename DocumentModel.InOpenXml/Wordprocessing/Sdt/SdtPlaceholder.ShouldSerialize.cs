namespace DocumentModel.Wordprocessing;

public partial class SdtPlaceholder
{
  public bool ShouldSerializeDocPartReference() => DocPartReference is not null;
}
