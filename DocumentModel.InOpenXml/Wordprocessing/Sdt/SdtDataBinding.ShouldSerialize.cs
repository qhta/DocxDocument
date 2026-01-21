namespace DocumentModel.Wordprocessing;

public partial class SdtDataBinding
{
  public bool ShouldSerializePrefixMappings() => PrefixMappings is not null;
  public bool ShouldSerializeXPath() => XPath is not null;
  public bool ShouldSerializeStoreItemId() => StoreItemId is not null;
}
