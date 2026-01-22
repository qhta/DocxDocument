namespace DocumentModel.Drawings;

public partial class ExtraColorSchemeList
{
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
