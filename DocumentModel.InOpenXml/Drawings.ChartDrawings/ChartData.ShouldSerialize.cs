namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ChartData
{
  public bool ShouldSerializeExternalData() => ExternalData is not null;
  public bool ShouldSerializeData() => Data is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
