namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class StringDimension
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeFormula() => Formula is not null;
  public bool ShouldSerializeNfFormula() => NfFormula is not null;
  public bool ShouldSerializeStringLevel() => StringLevel is not null;
}
