namespace DocumentModel.Drawings;

public partial class VideoFromFile
{
  public bool ShouldSerializeLink() => Link is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
