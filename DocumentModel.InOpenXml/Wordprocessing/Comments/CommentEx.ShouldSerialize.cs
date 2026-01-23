namespace DocumentModel.Wordprocessing;

public partial class CommentEx
{
  public bool ShouldSerializeParaId() => ParaId is not null;
  public bool ShouldSerializeParaIdParent() => ParaIdParent is not null;
  public bool ShouldSerializeDone() => Done is not null;
}
