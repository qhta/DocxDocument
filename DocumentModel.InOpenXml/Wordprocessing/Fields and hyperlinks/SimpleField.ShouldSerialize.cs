namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SimpleField<T> 
{
  public bool ShouldSerializeInstruction() => !String.IsNullOrEmpty(Instruction);
  public bool ShouldSerializeFieldLock() => FieldLock is not null;
  public bool ShouldSerializeDirty() => Dirty is not null;
  public bool ShouldSerializeFieldData() => !String.IsNullOrEmpty(FieldData);
}
