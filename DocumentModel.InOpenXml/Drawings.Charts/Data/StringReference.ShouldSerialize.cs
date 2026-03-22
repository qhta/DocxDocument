namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class StringReference
{
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
  public bool ShouldSerializeStringCache() => StringCache is not null;
  public bool ShouldSerializeStrRefExtension() => StrRefExtension is not null;
}
