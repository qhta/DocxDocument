namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class MarkupStartRangeElement<T1, T2> 
{
  public bool ShouldSerializeDisplacedByCustomXml() => DisplacedByCustomXml is not null;
  public bool ShouldSerializePairedElement() => PairedElement is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAuthor() => !String.IsNullOrEmpty(Author);
  public bool ShouldSerializeDate() => Date is not null;
}
