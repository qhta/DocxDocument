namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Comment
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeAuthor() => !String.IsNullOrEmpty(Author);
  public bool ShouldSerializeInitials() => !String.IsNullOrEmpty(Initials);
  public bool ShouldSerializeDate() => Date is not null && ShouldSerialize(Date);
  public bool ShouldSerializeParaId() => ParaId is not null && ShouldSerialize(ParaId);
  public bool ShouldSerializeDurableId() => DurableId is not null && ShouldSerialize(DurableId);
}
