namespace DocumentModel.Wordprocessing;

public partial class NoteReference<T> 
{
  public bool ShouldSerializeCustomMarkFollows() => CustomMarkFollows is not null;
  public bool ShouldSerializeId() => Id is not null;
}
