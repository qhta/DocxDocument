namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class TickLabels
{
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
