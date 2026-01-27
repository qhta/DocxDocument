namespace DocumentModel.Drawings.Office.ScriptLink;

#pragma warning disable CS1591

public partial class ScriptLink
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
