namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class ParagraphProperties
{
  public bool ShouldSerializeJustification() => Justification is not null;
}
