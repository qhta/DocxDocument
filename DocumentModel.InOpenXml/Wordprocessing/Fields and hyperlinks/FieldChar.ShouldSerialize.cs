namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FieldChar
{
  public bool ShouldSerializeFieldCharType() => FieldCharType is not null && ShouldSerialize(FieldCharType);
  public bool ShouldSerializeFieldLock() => FieldLock is not null;
  public bool ShouldSerializeDirty() => Dirty is not null;
  public bool ShouldSerializeFieldData() => !String.IsNullOrEmpty(FieldData);
  public bool ShouldSerializeFormFieldData() => FormFieldData is not null && ShouldSerialize(FormFieldData);
  public bool ShouldSerializeNumberingChange() => NumberingChange is not null && ShouldSerialize(NumberingChange);
}
