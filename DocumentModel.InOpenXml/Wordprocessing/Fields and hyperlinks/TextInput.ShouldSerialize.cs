namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TextInput
{
  public bool ShouldSerializeTextBoxFormFieldType() => TextBoxFormFieldType is not null && ShouldSerialize(TextBoxFormFieldType);
  public bool ShouldSerializeDefaultTextBoxFormFieldString() => !String.IsNullOrEmpty(DefaultTextBoxFormFieldString);
  public bool ShouldSerializeMaxLength() => MaxLength is not null && ShouldSerialize(MaxLength);
  public bool ShouldSerializeFormat() => !String.IsNullOrEmpty(Format);
}
