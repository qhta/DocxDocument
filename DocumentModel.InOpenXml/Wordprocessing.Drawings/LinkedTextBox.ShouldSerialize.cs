namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class LinkedTextBox
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeSequence() => Sequence is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
