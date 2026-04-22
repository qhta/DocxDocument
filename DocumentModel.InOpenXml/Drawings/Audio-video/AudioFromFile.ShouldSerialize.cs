namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AudioFromFile
{
  public bool ShouldSerializeLink() => !String.IsNullOrEmpty(Link);
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
