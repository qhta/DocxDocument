namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class HeaderFooter
{
  public bool ShouldSerializeAlignWithMargins() => AlignWithMargins is not null;
  public bool ShouldSerializeDifferentOddEven() => DifferentOddEven is not null;
  public bool ShouldSerializeDifferentFirst() => DifferentFirst is not null;
  public bool ShouldSerializeOddHeaderXsdString() => !String.IsNullOrEmpty(OddHeaderXsdString);
  public bool ShouldSerializeOddFooterXsdString() => !String.IsNullOrEmpty(OddFooterXsdString);
  public bool ShouldSerializeEvenHeaderXsdString() => !String.IsNullOrEmpty(EvenHeaderXsdString);
  public bool ShouldSerializeEvenFooterXsdString() => !String.IsNullOrEmpty(EvenFooterXsdString);
  public bool ShouldSerializeFirstHeaderXsdString() => !String.IsNullOrEmpty(FirstHeaderXsdString);
  public bool ShouldSerializeFirstFooterXsdString() => !String.IsNullOrEmpty(FirstFooterXsdString);
}
