namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class YValues
{
  public bool ShouldSerializeNumberReference() => NumberReference is not null;
  public bool ShouldSerializeNumberLiteral() => NumberLiteral is not null;
}
