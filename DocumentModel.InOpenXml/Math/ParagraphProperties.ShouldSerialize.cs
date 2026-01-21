namespace DocumentModel.Math;

public partial class ParagraphProperties
{
  public bool ShouldSerializeJustification() => Justification is not null;
}
