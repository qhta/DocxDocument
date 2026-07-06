namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class TextBox
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeStyle() => !String.IsNullOrEmpty(Style);
  public bool ShouldSerializeInset() => !String.IsNullOrEmpty(Inset);
  public bool ShouldSerializeSingleClick() => SingleClick is not null;
  //public bool ShouldSerializeTextBoxContent() => TextBoxContent is not null;
}
