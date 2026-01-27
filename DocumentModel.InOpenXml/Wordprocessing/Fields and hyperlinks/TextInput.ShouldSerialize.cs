namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TextInput
{
  public bool ShouldSerializeTextBoxFormFieldType() => TextBoxFormFieldType is not null;
  public bool ShouldSerializeDefaultTextBoxFormFieldString() => DefaultTextBoxFormFieldString is not null;
  public bool ShouldSerializeMaxLength() => MaxLength is not null;
  public bool ShouldSerializeFormat() => Format is not null;
}
