namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AudioFromFile
{
  public bool ShouldSerializeLink() => Link is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
