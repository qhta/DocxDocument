namespace DocumentModel.Drawings;

public partial class CustomColorList
{
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
