namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class DataModelExtension
{
  public bool ShouldSerializeDataModelExtensionBlock() => DataModelExtensionBlock is not null;
  public bool ShouldSerializeRecolorImages() => RecolorImages is not null;
}
