namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class MarkupEndRangeElement<T1, T2> 
{
  public bool ShouldSerializePairedElement() => PairedElement is not null;
}
