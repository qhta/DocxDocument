namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocComments
{
  public bool ShouldSerializeComments() => Comments is not null && ShouldSerialize(Comments);
  public bool ShouldSerializeCommentsEx() => CommentsEx is not null && ShouldSerialize(CommentsEx);
  public bool ShouldSerializeCommentsIds() => CommentsIds is not null && ShouldSerialize(CommentsIds);
  public bool ShouldSerializeCommentsExtensible() => CommentsExtensible is not null && ShouldSerialize(CommentsExtensible);
}
