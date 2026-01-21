namespace DocumentModel.Drawings.Office.OEmbed;

public partial class OEmbedShared
{
  public bool ShouldSerializeSrcUrl() => SrcUrl is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
