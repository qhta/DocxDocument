namespace DocumentModel.Wordprocessing;

public partial class Comment
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeInitials() => Initials is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeParaId() => ParaId is not null;
  public bool ShouldSerializeDurableId() => DurableId is not null;
}
