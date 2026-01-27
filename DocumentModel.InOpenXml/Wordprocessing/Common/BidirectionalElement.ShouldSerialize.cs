namespace DocumentModel.Wordprocessing;

public partial class BidirectionalElement<T>
{
  public bool ShouldSerializeType() => Type is not null;
}
