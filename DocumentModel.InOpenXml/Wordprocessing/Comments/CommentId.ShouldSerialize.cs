namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CommentId
{
  public bool ShouldSerializeParaId() => ParaId is not null;
  public bool ShouldSerializeDurableId() => DurableId is not null;
}
