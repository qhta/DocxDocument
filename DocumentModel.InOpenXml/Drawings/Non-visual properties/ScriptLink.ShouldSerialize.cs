namespace DocumentModel.Drawings.Office.ScriptLink;

public partial class ScriptLink
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
