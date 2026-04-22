namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NoteReference<T> 
{
  public bool ShouldSerializeCustomMarkFollows() => CustomMarkFollows is not null;
  public bool ShouldSerializeId() => Id is not null;
}
