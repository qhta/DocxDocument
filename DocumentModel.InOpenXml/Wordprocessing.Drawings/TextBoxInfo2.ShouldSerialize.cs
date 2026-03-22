namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class TextBoxInfo2
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeTextBoxContent() => TextBoxContent is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
