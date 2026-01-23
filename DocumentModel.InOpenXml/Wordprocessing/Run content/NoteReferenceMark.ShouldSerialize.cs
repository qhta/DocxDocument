namespace DocumentModel.Wordprocessing;

public partial class NoteReferenceMark<T> 
{
  public bool ShouldSerializeType() => Type is not null;
}
