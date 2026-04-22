namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtDataBinding
{
  public bool ShouldSerializePrefixMappings() => !String.IsNullOrEmpty(PrefixMappings);
  public bool ShouldSerializeXPath() => !String.IsNullOrEmpty(XPath);
  public bool ShouldSerializeStoreItemId() => !String.IsNullOrEmpty(StoreItemId);
}
