namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CommentEx
{
  public bool ShouldSerializeParaId() => ParaId is not null && ShouldSerialize(ParaId);
  public bool ShouldSerializeParaIdParent() => ParaIdParent is not null && ShouldSerialize(ParaIdParent);
  public bool ShouldSerializeDone() => Done is not null;
}
