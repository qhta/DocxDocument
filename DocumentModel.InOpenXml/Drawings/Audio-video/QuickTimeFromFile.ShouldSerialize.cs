namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class QuickTimeFromFile
{
  public bool ShouldSerializeLink() => !String.IsNullOrEmpty(Link);
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
