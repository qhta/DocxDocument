namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BidirectionalElement<T>
{
  public bool ShouldSerializeType() => Type is not null;
}
