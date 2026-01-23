namespace DocumentModel.Wordprocessing;

public partial class HeaderFooterReferenceType<T> 
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeId() => Id is not null;
}
