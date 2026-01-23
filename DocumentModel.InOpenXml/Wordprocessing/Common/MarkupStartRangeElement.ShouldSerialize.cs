namespace DocumentModel.Wordprocessing;

public partial class MarkupStartRangeElement<T1, T2> 
{
  public bool ShouldSerializeDisplacedByCustomXml() => DisplacedByCustomXml is not null;
  public bool ShouldSerializePairedElement() => PairedElement is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
}
