namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class HeaderFooterReferenceType<T> 
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeId() => Id is not null;
}
