namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class NumberReference
{
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
  public bool ShouldSerializeNumberingCache() => NumberingCache is not null;
  public bool ShouldSerializeNumRefExtension() => NumRefExtension is not null;
}
