namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class HeaderFooter
{
  public bool ShouldSerializeAlignWithMargins() => AlignWithMargins is not null;
  public bool ShouldSerializeDifferentOddEven() => DifferentOddEven is not null;
  public bool ShouldSerializeDifferentFirst() => DifferentFirst is not null;
  public bool ShouldSerializeOddHeader() => !String.IsNullOrEmpty(OddHeader);
  public bool ShouldSerializeOddFooter() => !String.IsNullOrEmpty(OddFooter);
  public bool ShouldSerializeEvenHeader() => !String.IsNullOrEmpty(EvenHeader);
  public bool ShouldSerializeEvenFooter() => !String.IsNullOrEmpty(EvenFooter);
  public bool ShouldSerializeFirstHeader() => !String.IsNullOrEmpty(FirstHeader);
  public bool ShouldSerializeFirstFooter() => !String.IsNullOrEmpty(FirstFooter);
}
