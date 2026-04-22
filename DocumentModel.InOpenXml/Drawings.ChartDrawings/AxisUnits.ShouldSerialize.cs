namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class AxisUnits
{
  public bool ShouldSerializeUnit() => Unit is not null;
  public bool ShouldSerializeAxisUnitsLabel() => AxisUnitsLabel is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
