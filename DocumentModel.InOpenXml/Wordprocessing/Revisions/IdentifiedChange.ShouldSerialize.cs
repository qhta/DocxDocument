namespace DocumentModel.Wordprocessing;

public partial class IdentifiedChange<T> 
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
}
