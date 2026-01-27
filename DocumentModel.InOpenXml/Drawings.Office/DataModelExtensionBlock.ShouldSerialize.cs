namespace DocumentModel.Drawings.Office;

#pragma warning disable CS1591

public partial class DataModelExtensionBlock
{
  public bool ShouldSerializeRelId() => RelId is not null;
  public bool ShouldSerializeMinVer() => MinVer is not null;
}
