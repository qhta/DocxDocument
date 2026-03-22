namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class TextBox
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeInset() => Inset is not null;
  public bool ShouldSerializeSingleClick() => SingleClick is not null;
  public bool ShouldSerializeTextBoxContent() => TextBoxContent is not null;
}
