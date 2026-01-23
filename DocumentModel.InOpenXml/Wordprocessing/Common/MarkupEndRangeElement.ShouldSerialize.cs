namespace DocumentModel.Wordprocessing;

public partial class MarkupEndRangeElement<T1, T2> 
{
  public bool ShouldSerializePairedElement() => PairedElement is not null;
}
