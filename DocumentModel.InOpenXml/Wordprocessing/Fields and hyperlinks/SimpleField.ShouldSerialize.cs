namespace DocumentModel.Wordprocessing;

public partial class SimpleField<T>
{
  public bool ShouldSerializeInstruction() => Instruction is not null;
  public bool ShouldSerializeFieldLock() => FieldLock is not null;
  public bool ShouldSerializeDirty() => Dirty is not null;
  public bool ShouldSerializeFieldData() => FieldData is not null;
}
