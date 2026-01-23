namespace DocumentModel.Wordprocessing;

public partial class CommentId
{
  public bool ShouldSerializeParaId() => ParaId is not null;
  public bool ShouldSerializeDurableId() => DurableId is not null;
}
