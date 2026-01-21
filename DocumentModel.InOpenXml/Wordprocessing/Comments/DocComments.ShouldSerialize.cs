namespace DocumentModel.Wordprocessing;

public partial class DocComments
{
  public bool ShouldSerializeComments() => Comments is not null;
  public bool ShouldSerializeCommentsEx() => CommentsEx is not null;
  public bool ShouldSerializeCommentsIds() => CommentsIds is not null;
  public bool ShouldSerializeCommentsExtensible() => CommentsExtensible is not null;
}
