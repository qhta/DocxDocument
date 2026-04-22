namespace DocumentModel.Drawings.Office;

#pragma warning disable CS1591

public partial class DataModelExtensionBlock
{
  public bool ShouldSerializeRelId() => !String.IsNullOrEmpty(RelId);
  public bool ShouldSerializeMinVer() => !String.IsNullOrEmpty(MinVer);
}
