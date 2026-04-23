namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class EastAsianLayout
{
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
  public bool ShouldSerializeCombine() => Combine is not null;
  public bool ShouldSerializeCombineBrackets() => CombineBrackets is not null && ShouldSerialize(CombineBrackets);
  public bool ShouldSerializeVertical() => Vertical is not null;
  public bool ShouldSerializeVerticalCompress() => VerticalCompress is not null;
}
