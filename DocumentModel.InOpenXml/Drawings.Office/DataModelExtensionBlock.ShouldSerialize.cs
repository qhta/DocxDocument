namespace DocumentModel.Drawings.Office;

public partial class DataModelExtensionBlock
{
  public bool ShouldSerializeRelId() => RelId is not null;
  public bool ShouldSerializeMinVer() => MinVer is not null;
}
