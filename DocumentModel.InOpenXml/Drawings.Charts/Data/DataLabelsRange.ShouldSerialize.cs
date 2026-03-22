namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DataLabelsRange
{
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
  public bool ShouldSerializeDataLabelsRangeCache() => DataLabelsRangeCache is not null;
}
